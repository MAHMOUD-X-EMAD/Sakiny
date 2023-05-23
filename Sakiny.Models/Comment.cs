﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Models
{
    public class Comment: BaseModel
    {
      
        [ForeignKey("Apartment")]
        public int ApartmentId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public virtual Apartment Apartment { get; set; }
        public virtual User User { get; set; }

   
    }
}
