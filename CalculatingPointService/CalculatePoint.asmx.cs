using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatingPointService
{
    /// <summary>
    /// Summary description for CalculatePoint
    /// </summary>
    [WebService(Namespace = "http://CalculatePoint.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatePoint : System.Web.Services.WebService
    {

        [WebMethod]
        public Point CalculateIntersection(Straight FirstStraight, Straight SecondStraight)
        {

            //1) y1 = k*x1 + b
            //2) y2 = k*x2 + b

            var firstCoeff = FindСoefficients(FirstStraight);
            var secondCoeff = FindСoefficients(SecondStraight);

            //y = k1*x + b1
            //y = k2*x + b2

            var intersection = FindPoint(firstCoeff, secondCoeff);

            return new Point() { X = intersection.x, Y = intersection.y };
        }

        private static (float k, float b) FindСoefficients(Straight straight)
        {
            var y1 = straight.FirstPoint.Y;
            var x1 = straight.FirstPoint.X;
            var y2 = straight.SecondPoint.Y;
            var x2 = straight.SecondPoint.X;

            //1) y1 = k*x1 + b
            //2) y2 = k*x2 + b
            //b = y1 - k*x1
            //y2 = k*x2 + y1 - k*x1
            //y2 - y1 = (x2 - x1)*k
            //k = (y2-y1)/(x2 - x1)
            //tempY = y2-y1
            //tempX = x2 - x1

            var tempY = y2 - y1;
            var tempX = x2 - x1;
            var k = tempY==0 && tempX==0 ? 0.0f : tempY / tempX;
            var b = y1 - (k * x1);
            return (k, b);
        }

        private static (float x, float y) FindPoint((float k, float b) firstCoeff, (float k, float b) secondCoeff)
        {
            var k1 = firstCoeff.k;
            var b1 = firstCoeff.b;
            var k2 = secondCoeff.k;
            var b2 = secondCoeff.b;

            //y = k1*x + b1
            //y = k2*x + b2
            //k2*x + b2 = k1*x + b1
            //(k2 - k1)*x = b1 - b2
            //tempK = k2 - k1
            //tempB = b1 - b2
            //x = tempB / tempK
            var tempK = k2 - k1;
            var tempB = b1 - b2;
            var x = tempB == 0 && tempK == 0 ? 0.0f : tempB / tempK;
            var y = k1 * x + b1;
            return (x, y);
        }
    }

}
