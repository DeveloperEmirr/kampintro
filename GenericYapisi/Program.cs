using System;

namespace GenericYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("1 Nolu Müşteri");
            myList.Add("2 Nolu Müşteri");
            myList.Add("3 Nolu Müşteri");
            Console.WriteLine(myList.Count);
            Console.Read();
        }
    }


   class MyList<T>

    {
        T[] data;
        T[] TempArray;

        public MyList()
        {
            data = new T[0];
        }

        public void Add(T item)
        {
            TempArray = data;
            data = new T[data.Length + 1];

            for (int i = 0; i < TempArray.Length; i++)
            {
                data[i] = TempArray[i];
            }

            data[data.Length - 1] = item;
        }

        public int Count { get { return TempArray.Length; } }
    }
    
}
