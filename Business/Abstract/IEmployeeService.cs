using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<Employee> GetById(int employeeId);
        IDataResult<List<Employee>> GetAll();
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(int employeeId);
    }
}
