using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class UserFavorite:IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }

    }
}
