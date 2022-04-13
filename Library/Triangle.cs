namespace Library
{
    public class Triangle : IFigure
    {
        private double lineOne;
        private double lineTwo;
        private double lineThree;


        public Triangle(double lineOne, double lineTwo, double lineThree)
        {
            this.lineOne = lineOne;
            this.lineTwo = lineTwo;
            this.lineThree = lineThree;

            double sum12 = lineOne + lineTwo;
            double sum13 = lineOne + lineThree;
            double sum23 = lineTwo + lineThree;

            if (lineOne > sum23 || lineTwo > sum13 || lineThree > sum12)
            {
                throw new Exception("задан неправильный треугольник");
            }
        }


        public double GetSquare()
        {
            double sumSq12 = lineOne * lineOne + lineTwo * lineTwo;
            double sumSq13 = lineOne * lineOne + lineThree * lineThree;
            double sumSq23 = lineTwo * lineTwo + lineThree * lineThree;

            bool longest1 = sumSq23 == lineOne * lineOne;
            bool longest2 = sumSq13 == lineTwo * lineTwo;
            bool longest3 = sumSq12 == lineThree * lineThree;

            double output = 0;

            if (longest1)
            {
                output = lineTwo * lineThree / 2.0;
            }
            else if (longest2)
            {
                output = lineOne * lineThree / 2.0;
            }
            else if (longest3)
            {
                output = lineOne * lineTwo / 2.0;
            }
            else
            {
                double p = (lineOne + lineTwo + lineThree) / 2;
                output = Math.Sqrt(p * (p - lineOne) * (p - lineTwo) * (p - lineThree));
            }

            return output;
        }
    }
}
