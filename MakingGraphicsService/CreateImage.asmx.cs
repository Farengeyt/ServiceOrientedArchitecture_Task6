using System.Drawing;
using System.Web.Services;
using ZedGraph;

namespace MakingGraphicsService
{
    /// <summary>
    /// Summary description for CreateImage
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CreateImage : System.Web.Services.WebService
    {

        [WebMethod]
        public byte[] HelloWorld(Straight firstStraight, Straight secondStraight)
        {
            // Получим панель для рисования
            GraphPane pane = new GraphPane();

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            PointPair firstPoint = new PointPair(firstStraight.FirstPoint.X, firstStraight.FirstPoint.Y);
            PointPair secondPoint = new PointPair(firstStraight.SecondPoint.X, firstStraight.SecondPoint.Y);

            // Создадим список точек
            PointPairList list = new PointPairList() { firstPoint, secondPoint };

            string firstPointString = "[" + firstStraight.FirstPoint.X + ":" + firstStraight.FirstPoint.Y + "]";
            string secondPointString = "[" + firstStraight.SecondPoint.X + ":" + firstStraight.SecondPoint.Y + "]";

            string straightName = firstPointString + ", " + secondPointString;

            pane.AddCurve(straightName, list, Color.Blue, SymbolType.None);

            //--------------------------Second straight----------------------------------

            firstPoint = new PointPair(secondStraight.FirstPoint.X, secondStraight.FirstPoint.Y);
            secondPoint = new PointPair(secondStraight.SecondPoint.X, secondStraight.SecondPoint.Y);

            list = new PointPairList() { firstPoint, secondPoint };

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            firstPointString = "[" + secondStraight.FirstPoint.X + ":" + secondStraight.FirstPoint.Y + "]";
            secondPointString = "[" + secondStraight.SecondPoint.X + ":" + secondStraight.SecondPoint.Y + "]";

            straightName = firstPointString + ", " + secondPointString;

            pane.AddCurve(straightName, list, Color.Blue, SymbolType.None);


            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            pane.AxisChange();

            // Обновляем график
            Bitmap bmp = pane.GetImage();

            var imageBytes = (byte[])new ImageConverter().ConvertTo(bmp, typeof(byte[]));
            //bmp.Save("D:\\testingbmp.png");

            return imageBytes;
        }
    }
}
