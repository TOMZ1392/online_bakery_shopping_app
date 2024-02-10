using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models.Authorization
{
    public class ActionRole
    {
        [Key]
        public int ItemId { get; set; }
        public int Role { get; set; }
        public string ActionRoute { get; set; }
    }
}
