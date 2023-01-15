//Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами.
Console.Write("Введите целое число, количество элементов массива:"); 
int N=Convert.ToInt16(Console.ReadLine());
string[] array=new string[N];
for ( int i=0; i<N; i++ )
{
    Console.Write($"{i+1} - элемент массива: ");
    array[i]= Console.ReadLine();
}
string[] finalArray=new string[N];
int j=0;
Console.Write("Вывод элементов = 3 символам и меньше: ");
for ( int i=0; i<N; i++ )
 if (array[i].Length<=3) 
 {
    finalArray[j]=array[i];
    Console.Write($"{j+1}"+")"+$"{finalArray[j] }");
    j++;
 }
 
Console.WriteLine();