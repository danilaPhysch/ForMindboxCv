namespace Library
{
    public class Circle : IFigure
    {
        private readonly double radius;


        public Circle(double radius)
        {
            this.radius = radius;

            if (radius <= 0)
            {
                throw new Exception("задан неправильный радиус окружности");
            }
        }


        public double GetSquare() => 2 * Math.PI * radius * radius;
    }
}
