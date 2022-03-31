using System;

namespace _1er_applis
{
    class Program
    {
        static void Main(string[] args)
        {
            int VarA = 4;
            int VarB = 12;
            int VarC = 0;
            VarC = VarA;
            VarA = VarB;
            VarB = VarC;

            Console.WriteLine(VarA);
            Console.WriteLine(VarB);
           
        }
    }
}
