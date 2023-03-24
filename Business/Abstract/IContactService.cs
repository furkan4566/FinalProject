using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();
        IDataResult<Contact> GetById(int contactId);
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(int contactId);
        IDataResult<List<Contact>> GetUserById(int userId);
    }
}
