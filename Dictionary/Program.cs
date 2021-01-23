using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> vatandaslar = new MyDictionary<int, string>();
            vatandaslar.Add(123456789, "Gülce Arda");
            vatandaslar.Add(234567891, "Ayşe Arda");

        }
    }
}
