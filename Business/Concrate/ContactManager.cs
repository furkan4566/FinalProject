using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
          return new SuccessResult("işlem başarılı");
        }

        public IResult Delete(int contacttId)
        {
            _contactDal.Delete(contacttId);
            return new SuccessResult("işlem başarılı");
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll());
        }

        public IDataResult<Contact> GetById(int contactId)
        {
            return new SuccessDataResult<Contact>(_contactDal.Get(i=>i.Id==contactId));
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult("işlem başarılı");
        }
    }
}
