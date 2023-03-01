using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class UnderCategory:IEntity
    {
        public int Id { get; set; }
        public int SideCategoryId { get; set; }
        public string Name { get; set; }

    }
}
