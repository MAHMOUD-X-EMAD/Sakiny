﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Models.Models_Images
{
    public class MealsImages: IBaseModel<int>
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public bool IsDeleted { get; set; }
    }
}
