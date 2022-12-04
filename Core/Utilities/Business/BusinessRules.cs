using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)//bütün kuralları gez
            {
                if (!logic.Success)//kurala uymayanları bul
                {
                    return logic; //uyumsuları döndür.
                }
            }
            return null;
        }
    }
}
