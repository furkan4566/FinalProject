using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFavoriteService
    {
        IDataResult<Favorite> GetById(int userFavoriteId);
        IDataResult<List<Favorite>> GetAll();
        IResult Add(Favorite userFavorite);
        IResult Update(Favorite userFavorite);
        IResult Delete(int userFavoriteId);
        IDataResult<List<Favorite>> GetByUserId(int userId);

    }
}
