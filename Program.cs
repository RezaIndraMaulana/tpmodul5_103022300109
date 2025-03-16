using System;

namespace DataGenericApp
{
    class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }

    class Program
    {
        static void Main()
        {
            DataGeneric<string> dataNIM = new DataGeneric<string>("103022300109");
            dataNIM.PrintData();
            Console.ReadLine();
        }
    }
}
