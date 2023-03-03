using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFavoriteService
    {
        IDataResult<UserFavorite> GetById(int userFavoriteId);
        IDataResult<List<UserFavorite>> GetAll();
        IResult Add(UserFavorite userFavorite);
        IResult Update(UserFavorite userFavorite);
        IResult Delete(int userFavoriteId);
        IDataResult<List<UserFavorite>> GetByUserId(int userId);

    }
}
