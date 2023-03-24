using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entities.Concrate
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Commentt { get; set; }
        public string Image { get; set; }
        public int Like { get; set; }
        public DateTime DateTime { get; set; }
        public int StartCount { get; set; }
    }
}
