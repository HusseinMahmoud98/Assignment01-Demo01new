namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            ////Point
            //Point P01; //Declare for object from type 'Point'
            //P01.X = P01.Y = 12;

            //Console.WriteLine(P01.X); //12
            //Console.WriteLine(P01.Y); //12

            ////initialize with calling built-in or user-defined constructor
            //Point P02 = new Point(); //Point P02 = new Point();
            //Console.WriteLine(P02.X);
            //Console.WriteLine(P02.Y);

            ////initialize with calling built-in or user-defined constructor
            //Point P03 = new Point(1, 2); //Point P02 = new Point();
            //Console.WriteLine(P03.X); //1
            //Console.WriteLine(P03.Y); //2

            //Console.WriteLine(P03); //Demo01.Point

            //P03.PrintPoint(); //(1,2)
            //Console.WriteLine(P03.ToString()); //(1, 2) 

            #endregion

            #region Encapsulation Using Setter and Getter
            //Employee E01 = new Employee(1, "Hussein", -100);
            //E01.SetId(1);
            //E01.SetName("Hussein");
            //E01.SetSalary(-100);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());

            Employee E02 = new(2, "Mahmoud", 20000);
            Console.WriteLine(E02.GetId());
            Console.WriteLine(E02.GetName());
            Console.WriteLine(E02.GetSalary());

            Console.WriteLine(E02);

            #endregion
        }
    }
}
