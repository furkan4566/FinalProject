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
        public IResult Add(UserFavorite userFavorite)
        {
            _favoriteDal.Add(userFavorite);
            return new SuccessResult("Ekleme Başarılı");
        }

        public IResult Delete(int userFavoriteId)
        {
            _favoriteDal.Delete(userFavoriteId);
            return new SuccessResult("Silme işlemi başarılı");
        }

        public IDataResult<List<UserFavorite>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserFavorite> GetById(int userFavoriteId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserFavorite>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<UserFavorite>>(_favoriteDal.GetByUserId(userId));
        }

        public IResult Update(UserFavorite userFavorite)
        {
            throw new NotImplementedException();
        }
    }
}
