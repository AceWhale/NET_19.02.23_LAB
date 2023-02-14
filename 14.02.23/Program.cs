using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._23
{
    internal class Program
    {
        interface IOutput
        {
            void Show();
            void Show(string text);
        }
        interface IMath
        {
            int Max();
            int Min();
            float Avg();
            bool Search(int valueToSearch);
        }
        interface ISort
        {
            void SortAsc();
            void SortDesc();
            void SortByParam(bool isAsc);
        }

        class Array: IOutput, IMath, ISort
        {
            public string array_chr;
            public int[] array_int;
            public Array(string a)
            {
                array_chr = a;
            }
            public Array(params int[] a)
            {
                array_int = new int[a.Length];
                for(int i = 0; i < a.Length; i++)
                    array_int[i] = a[i];
            }
            public void Show()
            {
                if(array_chr != null)
                    Console.WriteLine(array_chr);
                if (array_int != null)
                    for (int i = 0; i < array_int.Length; i++)
                        Console.WriteLine(array_int[i]);
            }
            public void Show(string text)
            {
                Show();
                Console.WriteLine("info: "+text);
            }
            public int Max()
            {
                int max = 0;
                if (array_int != null)
                {
                    max = array_int[0];
                    for (int i = 0; i < array_int.Length; i++)
                        if (array_int[i] > max)
                            max = array_int[i];
                }
                return max;
            }
            public int Min()
            {
                int min = 0;
                if (array_int != null)
                {
                    min = array_int[0];
                    for (int i = 0; i < array_int.Length; i++)
                        if (array_int[i] < min)
                            min = array_int[i];
                }
                return min;
            }
            public float Avg()
            {
                float sum = 0;
                if (array_int != null)
                {
                    for (int i = 0; i < array_int.Length; i++)
                        sum += array_int[i];
                    sum /= array_int.Length;
                }
                return sum;
            }
            public bool Search(int valueToSearch)
            {
                bool find = false;
                if (array_int != null)
                    for (int i = 0; i < array_int.Length; i++)
                        if (valueToSearch == array_int[i])
                        {
                            find = true;
                            break;
                        }
                return find;
            }
            public void SortAsc()
            {
                if (array_int != null)
                    System.Array.Sort(array_int);
            }
            public void SortDesc()
            {
                if (array_int != null)
                {
                    System.Array.Sort(array_int);
                    System.Array.Reverse(array_int);
                }
            }
            public void SortByParam(bool isAsc)
            {
                if (array_int != null)
                {
                    if (isAsc != true)
                        SortDesc();
                    else
                        SortAsc();
                }

            }

        }
        static void Main(string[] args)
        {
            Array array = new Array(3,5,6,3);
            array.SortDesc();
            array.Show();
        }
    }
}
