using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtensionsStructEnum
{
    public static class Homework
    {
        public static int[] ArraySort()
        {
            int[] arr = { 5, 6, 3, 7, 8, 1, 2 };

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }   
            }

            return arr;
        }

        public static Person[] ArraySort2()
        {
            Person p1 = new Person("Rail", "Jannatov", 24);
            Person p2 = new Person("Sarkhan", "Efendizade", 23);
            Person p3 = new Person("Vugar", "Rustamov", 39);

            Person[] persons = { p1, p2, p3 };

            for (int i = 0; i < persons.Length - 1; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] > persons[j])
                    {
                        Person temp = persons[i];
                        persons[i] = persons[j];
                        persons[j] = temp;
                    }
                }
            }

            return persons;
        }

    }
}
