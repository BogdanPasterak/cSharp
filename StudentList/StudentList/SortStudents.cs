using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class SortStudents
    {
        public static void QuickSort(List<Student> students)
        {
            Console.WriteLine("Start Quick Sort");
            QuickSortRec(students, 0, students.Count - 1);
        }

        private static void QuickSortRec(List<Student> students, int low, int high)
        {
            if (low < high)
            {
                int p = partition(students, low, high);
                QuickSortRec(students, low, p - 1);
                QuickSortRec(students, p + 1, high);
            }
        }

        private static int partition(List<Student> students, int low, int high)
        {
            int pivot = students[high].ID;
            int i = low - 1;

            for (int j = low; j <= high; j++)
            {
                if (students[j].ID <= pivot)
                {
                    i++;
                    Student temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }

            return i;
        }

        public static void BubbleSort(List<Student> students)
        {
            bool swapped = false;
            int max = students.Count - 1;

            do
            {
                swapped = false;
                for (int i = 0; i < max; i++)
                {
                    if (students[i].ID > students[i + 1].ID)
                    {
                        Student temp = students[i];
                        students[i] = students[i + 1];
                        students[i + 1] = temp;
                        swapped = true;
                    }
                }
                max--;
            } while (swapped);
        }
    }
}
