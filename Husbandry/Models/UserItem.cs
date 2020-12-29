using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Husbandry.Models
{
    public class UserItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public bool Purchased { get; set; }
    }
}
