using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatingPointService
{
    [Serializable]
    public class Straight
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
    }

    [Serializable]
    public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }
    }
}