using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.CCS;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;

        //Conscrate injection=productManager ı,IProductDal a gevşek bagımlılık kıldık
        //Validation ve Business kodları farklı,validation dogrulama için kullanılır
        //Validation=nesnenin yapısal olarak dogru olup olmadıgını dogrulamya validation denir.örnek min kaç karakter olabilir(formdaki kırmızı uyarılar)
        //Business=yapıların uyumlu olup olmadıgı business le alakalı
        public ProductManager(IProductDal productDal, ICategoryService categoryService)//Kullanıcıdan productDal alınan yer.//entitymanager kendisinden başka entity enjekte edemez
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }
        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            var result = BusinessRules.Run(
             ChakeIfSameNotName(product.ProductName),
             CheckIfProductCountOfCategoryCorrect(product.CategoryId),
             CheckIfCategoryLimitExceded()
             );

            if (result != null)
            {
                return result;
            }
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        } 
        [CacheAspect] //KEY,VALUE
        public IDataResult<List<Product>> GetAll()
        {
            //if (DateTime.Now.Hour == 5)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }
        //[CacheAspect]
        //[PerformanceAspect(5)]
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(c => c.ProductId == productId),Messages.AccessTokenCreated);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        public IDataResult<List<Product>> GettAllByCategoryId(int id)
        {

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }
        public IDataResult<List<Product>> GetPopProductFirstTen()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetPopProductFirstTen());
        }
        public IDataResult<Product> GetCategoryInPopulerProduct(int categoryId)
        {
            return new SuccessDataResult<Product>(_productDal.GetCategoryInPopulerProduct(categoryId));
        }
        //[ValidationAspect(typeof(ProductValidator))]
        //[CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("işlem başarılı");
        }
        public IResult Delete(int productId)
        {
            _productDal.Delete(productId);
            return new SuccessResult("işlem başarılı");
        }
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
             
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result >=500)
            {
                return new ErrorResult(Messages.ProductCountofCategoryError);
            }
            return new SuccessResult();
        }
        private IResult ChakeIfSameNotName(string productName)
        {

            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if (result)//result==null,any yazmayıp bunu da yazılabilir.
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();
        }
        [TransactionScopeAspect]
        public IResult AddTransactionTest(Product product)
        {
            Add(product);
            if(product.UnitPrice<10)
            {
                throw new Exception("dfs");
            }
            Add(product);
            return null;
        }

        public IDataResult<List<Product>> GetSideCategoryForProduct(int categoryId, int sideCategoryId)
        {
            var productCategory = _productDal.GetAll(p => p.CategoryId == categoryId);
            var productSideCategory = _productDal.GetAll(p => p.SideCategoryId == sideCategoryId);
            List<Product> commonProducts = new List<Product>();
            if (productCategory !=null)
            {
                commonProducts = productCategory.Intersect(productSideCategory).ToList();
            }
            return new SuccessDataResult<List<Product>>(commonProducts);
        }
    }
}
