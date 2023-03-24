using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager (ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public IResult Add(Comment comment)
        {
            comment.DateTime = DateTime.Now;
            _commentDal.Add(comment);
            return new SuccessResult();
        }

        public IResult Delete(int commentId)
        {
            _commentDal.Delete(commentId);
            return new SuccessResult();
        }

        public IDataResult<List<Comment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comment> GetById(int commentId)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(s=>s.Id==commentId));
        }

        public IDataResult<List<Comment>> GetProductComment(int productId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetProductComment(productId));
        }

        public IDataResult<List<Comment>> GetUserComment(int userId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(i => i.UserId == userId));
        }

        public IResult Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
