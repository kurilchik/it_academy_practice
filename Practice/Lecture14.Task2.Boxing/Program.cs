using System;
using System.Collections;

namespace Lecture14.Task2.Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //System.Int32
            arrayList.Add(45); //true, boxing
            //System.Boolean
            arrayList.Add(true); //true, boxing
            //System.String
            arrayList.Add("Hello!"); //false
            //System.Double
            arrayList.Add(23.45); //true, boxing
        }
    }
}
