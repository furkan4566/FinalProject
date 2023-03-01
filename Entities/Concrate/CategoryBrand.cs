using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class CategoryBrand:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SideCategoryId { get; set; }
        public int BrandId  { get; set; }
    }
}
