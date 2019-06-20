using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSumOfPositive {
    //найти сумму положительных элементов массива
    class Program {
        public static void SumOfPositive() {
            int[] myArr = { 1, 2, 3, -4, 7, 5, -9 };    //инициализируем массив начальными значениями
            var sum = 0;    //результат суммы
            List<int> selectedItems = new List<int>();  //коллекция, в которую будем добавлять только положительные элементы из массива
            var result = (from i in myArr where i >= 0 select i);   //перебираем массив и выбираем только положительные элементы
            Console.WriteLine("Положительные элементы:");
            foreach (var i in result) {
                Console.Write(i + " "); //выводим положительные элементы
                selectedItems.Add(i);   //добавляем положительные элементы в коллекцию
                sum = selectedItems.Sum();  //вычисляем сумму элементов в коллекции и записываем результат
            }
            Console.Write("\n" + "Сумма положительных элементов равна = " + sum);
        }
        static void Main() {
            SumOfPositive();
            Console.ReadLine();
        }
    }
}
