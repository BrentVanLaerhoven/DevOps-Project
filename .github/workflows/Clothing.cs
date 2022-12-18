using System;
using Contentful.Core.Models;

namespace Clothing.Models 
{
    public class ClothingPiece {
        public String Type { get; set; }

        public int Price { get; set; }

        public String Size { get; set; }

        public String Color { get; set; }

        public String Brand { get; set; }

        public Asset Photo { get; set; }

        public String Fit { get; set; }
    }
}

