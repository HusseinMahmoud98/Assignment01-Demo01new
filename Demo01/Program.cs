namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //Point
            Point P01; //Declare for object from type 'Point'
            P01.X = P01.Y = 12;

            Console.WriteLine(P01.X); //12
            Console.WriteLine(P01.Y); //12

            //initialize with calling built-in or user-defined constructor
            Point P02 = new Point(); //Point P02 = new Point();
            Console.WriteLine(P02.X);
            Console.WriteLine(P02.Y);

            //initialize with calling built-in or user-defined constructor
            Point P03 = new Point(1, 2); //Point P02 = new Point();
            Console.WriteLine(P03.X); //1
            Console.WriteLine(P03.Y); //2

            Console.WriteLine(P03); //Assignment01.Point

            P03.PrintPoint(); //(1,2)
            Console.WriteLine(P03.ToString()); //(1, 2) 
            #endregion
        }
    }
}
