// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// Для строки можно использовать данный метод 
// string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
// (пользователь вводит в консоли числа через пробел и они формируют строку)
/*
int [] myArray = new int[5];
int count = 0;
Console.WriteLine("Введите последовательность из 5 чисел:\t ");
for(int i =0; i < myArray.Length; i++){
    myArray[i] = int.Parse(Console.ReadLine());
}
 Console.WriteLine($"В вашей последовательности количество чисел больше 0 = {CountElement(myArray)}");

//------ Еще какой-то метод-------Нахождение нахлждение количества положительных элементов
int CountElement(int[] myArray){
    int count = 0;
    foreach(int el in myArray){
        if(el > 0){
            count ++;
        }
    }
    return count;
}
*/



//Задача 43: Написать программу, которая на вход принимает массив 
//из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
//а на выходе выводит этот же массив, но отсортированный по возрастанию
//(от меньшего числа к большему).
/*
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");  
int temp = 0;
    for (int i = 0; i < size; i++){
        for( int j = 0; j < size; j++){
    if(array[i] < array[j]){
        temp = array[i];
        array [i] = array [j];
        array[j] = temp;
}
}
    }
Console.WriteLine($"[{String.Join(",", array)}]");
   //------МЕТОД заполнения массива--------
int [] GetArray(int size, int minValue, int maxValue){
 int[] res = new int[size];
 for(int i = 0; i < size; i++)
 {
    res[i] = new Random().Next(minValue, maxValue + 1);
 }   
 return res;
}
*/





