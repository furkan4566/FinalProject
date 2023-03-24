using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class FavoriteManager : IFavoriteService
    {
        IFavoriteDal _favoriteDal;
        public FavoriteManager(IFavoriteDal favoriteDal)
        {
            _favoriteDal= favoriteDal;
        }
        public IResult Add(Favorite userFavorite)
        {
            var result=_favoriteDal.Get(i => i.ProductId == userFavorite.ProductId);
            if(result!=null)
            {
                return new ErrorResult();
            }
            _favoriteDal.Add(userFavorite);
            return new SuccessResult("Ekleme Başarılı");
        }

        public IResult Delete(int userFavoriteId)
        {
            _favoriteDal.Delete(userFavoriteId);
            return new SuccessResult("Silme işlemi başarılı");
        }

        public IDataResult<List<Favorite>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Favorite> GetById(int userFavoriteId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Favorite>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<Favorite>>(_favoriteDal.GetByUserId(userId));
        }

        public IResult Update(Favorite userFavorite)
        {
            throw new NotImplementedException();
        }
    }
}
