using AspNetDistributedClient.CreateImageServiceReference;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetDistributedClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(float firstX1, float firstY1, float firstX2, float firstY2, float secondX1, float secondY1, float secondX2, float secondY2)
        {
            CreateImageSoapClient createImageClient = new CreateImageSoapClient();
            CalculatePointServiceReference.CalculatePointSoapClient calculatePointClient = new CalculatePointServiceReference.CalculatePointSoapClient();
            Straight first = new Straight() { FirstPoint = new CreateImageServiceReference.Point() { X = firstX1, Y = firstY1 }, SecondPoint = new CreateImageServiceReference.Point() { X = firstX2, Y = firstY2 } };
            Straight second = new Straight() { FirstPoint = new CreateImageServiceReference.Point() { X = secondX1, Y = secondY1 }, SecondPoint = new CreateImageServiceReference.Point() { X = secondX2, Y = secondY2 } };
            CalculatePointServiceReference.Straight first2 = new CalculatePointServiceReference.Straight() { 
                FirstPoint = new CalculatePointServiceReference.Point() { X = firstX1, Y = firstY1 },
                SecondPoint = new CalculatePointServiceReference.Point() { X = firstX2, Y = firstY2 } };
            CalculatePointServiceReference.Straight second2 = new CalculatePointServiceReference.Straight() { 
                FirstPoint = new CalculatePointServiceReference.Point() { X = secondX1, Y = secondY1 },
                SecondPoint = new CalculatePointServiceReference.Point() { X = secondX2, Y = secondY2 } };

            var result = calculatePointClient.CalculateIntersection(first2, second2);
            ViewBag.Message = "Intersection point [" + result.X + ", " + result.Y +"]";
            ViewBag.imageBytes = createImageClient.HelloWorld(first, second);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}