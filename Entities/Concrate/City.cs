using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
   public class City:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
