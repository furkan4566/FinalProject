using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrate
{
    public class OrderDetail:IEntity
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UnitPrice{ get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }

    }
}
