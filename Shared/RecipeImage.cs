﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIChef.Shared
{
    public class RecipeImage
    {
        public int Created { get; set; }
        public ImageData[] data { get; set; }
    }
    public class ImageData
    {
        public string url { get; set; }
    }

}
