using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrate
{
    public class SideCategory:IEntity
    {
        [Key]
        public int SCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string SCategoryName { get; set; }

    }
}
