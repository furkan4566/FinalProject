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
            _commentDal.Add(comment);
            return new SuccessResult();
        }

        public IResult Delete(int commentId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comment> GetById(int commentId)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(s=>s.Id==commentId));
        }

        public IResult Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
