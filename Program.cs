using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs
{
    class GenericArray<T>
    {
        private T[] array;
        private int length;

        public GenericArray(int capacity)
        {
            array = new T[capacity];
            length = 0;
        }

        public void Set(int index, T item)
        {
            array[index] = item;
        }

        public void Add(T item)
        {
            if (length < array.Length)
            {
                array[length] = item;
                length++;
            }
            else
            {
                Console.WriteLine("Array is full!");
            }
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < length)
            {
                for (int i = index; i < length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                length--;
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        public T Get(int index)
        {
            if (index >= 0 && index < length)
            {
                return array[index];
            }
            else
            {
                Console.WriteLine("Invalid index!");
                return default(T);
            }
        }

        public int Length()
        {
            return length;
        }

    }
    class LoginArray : GenericArray<string>
    {
        public LoginArray(int capacity) : base(capacity)
        {
        }
    }

    class PasswordArray : GenericArray<string>
    {
        public PasswordArray(int capacity) : base(capacity)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericArray<int> intArray = new GenericArray<int>(5);
            intArray.Add(10);
            intArray.Add(20);
            intArray.Add(10);
            intArray.Add(50);
            Console.WriteLine("Количество элементов в intArray: " + intArray.Length());
            Console.WriteLine("Элемент по индексу 1: " + intArray.Get(1));
            intArray.Remove(1);
            Console.WriteLine("Length of intArray after removing element at index 1: " + intArray.Length());

            GenericArray<string> stringArray = new GenericArray<string>(3);
            stringArray.Add("Hello");
            stringArray.Add("World");
            Console.WriteLine("Length of stringArray: " + stringArray.Length());
            Console.WriteLine("Element at index 0: " + stringArray.Get(0));

            GenericArray<double> doubleArray = new GenericArray<double>(4);
            doubleArray.Add(1.23);
            doubleArray.Add(4.56);
            Console.WriteLine("Length of doubleArray: " + doubleArray.Length());
            Console.WriteLine("Element at index 1: " + doubleArray.Get(1));

            LoginArray loginArray = new LoginArray(10);
            PasswordArray passwordArray = new PasswordArray(10);

            loginArray.Add("andrew12121");
            passwordArray.Add("frtgseef");

            loginArray.Add("maxaxa");
            passwordArray.Add("rgthdeg");
            Console.WriteLine(loginArray.Get(0) + "\n" + passwordArray.Get(0));
            Console.ReadKey();
        }
    }
}
