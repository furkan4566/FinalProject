using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrate;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependecnyResoivers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        //SingleInstance 1 kere ınstance referans no üretir ve herkes e verir.
        //projeye autofac i tanıtman gerekiyor(program.cs)
        protected override void Load(ContainerBuilder builder)//proje çalıştıgı zaman harekte geçen fonksiyon
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<ProductPropertyManager>().As<IProductPropertyService>().SingleInstance();
            builder.RegisterType<EfProductPropertyDal>().As<IProductPropertyDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            builder.RegisterType<SideCategoryManager>().As<ISideCategoryService>();
            builder.RegisterType<EfSideCategoryDal>().As<ISideCategoryDal>();

            builder.RegisterType<CommentManager>().As<ICommentService>();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();

            builder.RegisterType<ProductImageManager>().As<IProductImageService>();
            builder.RegisterType<EfProductImageDal>().As<IProductImgDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<BasketManager>().As<IBasketService>();
            builder.RegisterType<EfBasketDal>().As<IBasketDal>();

            builder.RegisterType<UnderCategoryManager>().As<IUnderCategoryService>();
            builder.RegisterType<EfUnderCategoryDal>().As<IUnderCategoryDal>();

            builder.RegisterType<CategoryBrandManager>().As<ICategoryBrandService>();
            builder.RegisterType<EfCategoryBrandDal>().As<ICategoryBrandDal>();

            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            builder.RegisterType<FavoriteManager>().As<IFavoriteService>();
            builder.RegisterType<EfFavoriteDal>().As<IFavoriteDal>();

            builder.RegisterType<EfCityDal>().As<ICityDal>();
            builder.RegisterType<CityManager>().As<ICityService>();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>();
            builder.RegisterType<DistrictManager>().As<IDistrictService>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
