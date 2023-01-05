namespace _02_PointCoordinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointCoordinates point1 = new PointCoordinates();
            point1.X = 100;
            point1.Y = 10;

            PointCoordinates point2 = new PointCoordinates();
            point2.X = 200;
            point2.Y = 20;

            PointCoordinates point3 = new PointCoordinates();
            point3.X = 300;
            point3.Y = 30;

            PointCoordinates point4 = new PointCoordinates();
            point4.X = 400;
            point4.Y = 40;

            PointCoordinates point5 = new PointCoordinates();
            point5.X = 500;
            point5.Y = 50;

            PointCoordinates point6 = new PointCoordinates();
            point6.X = 600;
            point6.Y = 60;

            PointCoordinates point7 = new PointCoordinates();
            point7.X = 700;
            point7.Y = 70;

            PointCoordinates point8 = new PointCoordinates();
            point8.X = 800;
            point8.Y = 80;

            PointCoordinates point9 = new PointCoordinates();
            point9.X = 900;
            point9.Y = 90;

            PointCoordinates point10 = new PointCoordinates();
            point10.X = 1000;
            point10.Y = 100;

            PointCoordinates[] points = { point1, point2, point3, point4, point6, point7, point8, point9, point10 };
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i].GetCoordinates());
            }
        }
    }
}
