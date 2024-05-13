using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Classes
{
    internal class Realizator_Class
    {

        public Class_Parametr ToForvard(Class_Parametr param)
        {
          int[] mas_of_list = param.List.ToArray();


            for (int i = 0; i < mas_of_list.Length; i++)
            {
                // Помечаем, что сортировка завершена для оптимизации (если массив уже отсортирован)
                bool swapped = false;
                // Последние i элементов уже находятся на своих местах
                for (int j = 0; j < mas_of_list.Length - i - 1; j++)
                {
                    // Если текущий элемент больше следующего, меняем их местами
                    if (mas_of_list[j] > mas_of_list[j + 1])
                    {
                        var temp_area = mas_of_list[j];
                        mas_of_list[j] = mas_of_list[j + 1];
                        mas_of_list[j + 1] = temp_area;
                        swapped = true;
                        param.List = mas_of_list.ToList<int>();
                        param.index = j;
                        return param;
                    }
                }
                if (!swapped)
                    param.isOver = true;
            }
            

          return param;
        }
        public Class_Parametr toBack(Class_Parametr param)
        {
            int[] mas_of_list =param.List.ToArray();


            for (int i = 0; i < mas_of_list.Length; i++)
            {
                // Помечаем, что сортировка завершена для оптимизации (если массив уже отсортирован)
                // Последние i элементов уже находятся на своих местах
                for (int j = 1; j < mas_of_list.Length - i; j++)
                {
                    // Если текущий элемент больше следующего, меняем их местами
                    if (mas_of_list[j-1] < mas_of_list[j])
                    {
                        var temp_area = mas_of_list[j];
                        mas_of_list[j] = mas_of_list[j - 1];
                        mas_of_list[j - 1] = temp_area;
                        param.index = j;
                        param.List = mas_of_list.ToList<int>();
                        return param;
                    }
                }
         
            }
            return param;
        }
    }
}
