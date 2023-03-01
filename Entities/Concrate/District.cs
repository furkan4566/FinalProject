using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
   public class District:IEntity
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int CityId { get; set; }

    }
}
