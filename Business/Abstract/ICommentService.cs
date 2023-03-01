using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public interface ICommentService
    {
        IDataResult<Comment> GetById(int commentId);
        IDataResult<List<Comment>> GetAll();
        IResult Add(Comment comment);
        IResult Update(Comment comment);
        IResult Delete(int commentId);
        IDataResult<List<Comment>> GetProductComment(int productId);
        IDataResult<List<Comment>> GetUserComment(int productId);
    }
}
