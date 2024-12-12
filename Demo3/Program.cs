namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value type Casting
            #region implicit Casting

            //int X = 4; // 4 Bytes
            //long Y = /*(long)*/X;
            #endregion
            #region Explict Casting - Unsafe Casting
            //long X = 10122323323;//8 Bytes
            //int Y;
            //checked
            //{
            //     Y = (int)X; 
            //}
            //Console.WriteLine(Y);
            #region Parse
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter data user");
            //Console.WriteLine("Enter name");
            //String Name = Console.ReadLine();

            //Console.WriteLine("Enter Age :");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Salary:");
            //double Salary = Convert.ToDouble(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Name :"+Name + "Age: "+Age+ "Salary:" +Salary);


            #endregion

            #endregion
            #region Oprators
            #region unary Oprators [++. --]
            //int X = 5;
            //X++;
            //++X;
            //Console.WriteLine(++X);
            //Console.WriteLine(X);
            //Console.WriteLine(--X);
            //Console.WriteLine(X--);
            //Console.WriteLine(X);
            #region Binary Operator
            //int Sum, Mul, Sub, Div, Mod;
            //int A = 8;
            //int B = 5;
            //Sum = A + B; //15
            //Sub = A - B;
            //Div = A / B;
            //Mul = A * B;
            //Mod = A % B;
            //Console.WriteLine(Sum);
            #endregion
            #region Assignment Operator
            //int Y = 10;
            //X += 10; //X=X+10
            //X-= 10; 
            //X*=10;
            //X/=10;
            //X%=10;  
            #endregion
            #region Relational Operators
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A < B);   
            #endregion
            #region Logical Operators
            //Console.WriteLine(true && false);
            //true && true => true
            // true && false = false;
            //false && false = false;
            //Console.WriteLine(true || false);
            // true || true => true
            // true || false = true;
            //false ||false = false;
            #region Ternary Operator
            //4
            //int X = 5;
            //string Message = X > 4 ? "X Greater Than 4" : "x less than or  Equal 4";
            //Console.WriteLine(Message);

            #region Operator Periorety
            /*
             1.Unary Operator [PreFix]
             2.()
             3. * / %
             4 + =
           
            */
            //int A = 20;
            //int B = 15;
            //int C = 10;
            //int D = 5;
            //int Result;
            // Result = (A + B) * C / D;//
            // Result = A++ * C
            // Result = A * C;
            // Console.WriteLine(Result); 
            #region String Formating
            //Equation = X + y = Result
            //Equation = 10 + 5 = 15
            //int x = 5
            //int y = 10;
            //int Result = X + y;
            //Console.WriteLine("Equation = "+ X + "+ " + y+" = "+ Result);
            //string => Immutable Datatype
            //string Name = "Ahmed";
            //Name ="Ali";

            #region Composite Formate
            //string Message = String.Format("Equation = {0} + {1} = {2}",X,y, Result );
            // Console.WriteLine(Message);
            // Console.WriteLine("Equation = {0} + {1} = {2}", X, y, Result);
            #region String Manipolition
            //String Interpolation => $
            // Console.WriteLine($"Equation = {X} + {y} = {2}", X, y, Result);
            #region IF Else - Switch Case
            //Console.WriteLine("Month");
            //int MonthNuber = int.Parse(Console.ReadLine());

            //if (MonthNuber == 2)
            //{
            //    Console.WriteLine("jan");
            //}
            //else if (MonthNuber == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //else if (MonthNuber == 3)
            //{
            //    Console.WriteLine("mar");

            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            //switch(MonthNuber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //        case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //        case 3:
            //        Console.WriteLine("Invaild");
            //        break;
            //}
            //Console.WriteLine("Enter Name");
            //String Name = Console.ReadLine();
            //if (Name == "Ali")
            //{
            //    Console.WriteLine("HellO Ali");
            //}
            //else if (Name == "Aliaa")
            //{
            //    Console.WriteLine("Hello Aliaa");

            //}
            //else if (Name == "Ahmed") ;
            //{
            //    Console.WriteLine("Hello Ahmed");

            //}
            #region Goto
            //Console.WriteLine("Enter Option");
            //int Option = int.Parse(Console.ReadLine());

            //    switch (Option)
            //    {
            //        case 3000:
            //            Console.WriteLine("3");
            //        goto case 2000;
            //    case 2000:

            //        Console.WriteLine("2");
            //            goto case 1000;

            //        case 1000:
            //            Console.WriteLine("1");
            //            break;
            //    }

            #region Evaluation Of switch Case

            #region C#6


            //Console.WriteLine("Enter Age");
            //int Age = int.Parse(Console.ReadLine());
            //switch (Age)
            //{

            //    case > 22:
            //        Console.WriteLine("Age Greater T 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Age Less T 22");
            //        break;
            //    default:
            //        Console.WriteLine("Age Equal 22");
            //        break;
            //}
            #endregion
            #region C#7
            //object obj = new object();
            //obj = "Mostafa";
            //obj = 10;
            //obj = true;

            //switch(obj) {
            //    case int Number when Number > 10 %% Number < 20:
            //        Console.WriteLine($"{Number} is int");
            //        break;
            //    case string Name:
            //        Console.WriteLine($"{Name} is String ");
            //        break;
            //    case bool Flag:
            //        Console.WriteLine($"{Flag}is bool");
            //        break;




            #endregion
            #region C# 8
            #region EX1


            //Console.WriteLine("Enter Option");
            //int Opation = int.Parse(Console.ReadLine());
            //string Messsage = Opation switch

            //{
            //    1 => "1",
            //    2 => "2",
            //    3 => "3",
            //  => "invalid"


            //};
            #endregion
            #region Ex02
            //Employee E01 = new Employee();
            //E01 Name = "Ali";
            //E01 id = 10;
            //E01 Age = 22;


            // String Massege = E01 switch
            // {
            //     { Id:10, Name:"Alaa",Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //     { Id: 10, Name: "Ali", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            // }


            #endregion
            #region C#9
            //Employee E01 = new Employee();
            //E01 Name = "Alaa";
            //E01 id = 10;
            //E01 Age = 22;


            //String Massege = E01 switch
            //{
            //    { Age: > 22 and < 25 } => $"{E01.Id} : {E01.Name}: {E01.Age}",
            //    { Age: > 25 or  23 } => $"{E01.Id} : {E01.Name}: {E01.Age}",
            //    { Age: 20 } => $"{E01.Id} : {E01.Name}: {E01.Age}",
            //};

            #endregion
            #endregion
            #endregion

            #endregion
            #endregion
            #endregion
            #endregion
            #endregion

            #endregion
            #endregion

            #endregion
            #endregion
            #endregion
            #endregion


        }
    }
}
