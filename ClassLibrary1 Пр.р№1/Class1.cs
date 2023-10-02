using System;

namespace ClassLibrary1_Пр.р_1 // Имя пространства
{
    public class Class1 // имя класса
    {
        /// <summary>
        /// GetRaz имя метода
        /// </summary>
        /// <param name="K"></param> входной параметр
        /// <param name="sum"></param> входной, изменяющийся, выходящий параметр
        /// <param name="kol"></param> входной, изменяющийся, выходящий параметр
        /// <param name="value"></param> объявляемый, изменяющийся, выходящий параметр
        /// <param name="raz"></param> входной, изменяющийся, выходящий параметр
        public static void GetRaz(int K, ref int sum, ref int kol, out int value, ref int raz) 
        {
            value = 0;
            Random rnd = new Random();


            value = rnd.Next(2, 10); // Присваем значение рандомное значение от 2 до 10
            sum += value; // перезаписываем значение и складываем
            raz -= value; // перезаписываем значение и вычитаем
            kol++; // прибавляем к счётчику единицу

        }
    }
}
