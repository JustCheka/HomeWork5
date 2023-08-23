using System.Diagnostics.CodeAnalysis;

void InitArr(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArr(int[] arr){
    foreach(var el in arr){
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

int CountEvenNum(int[] arr){
    int sum = 0;
    foreach(var el in arr){
        if (el % 2 == 0) sum++;
    }
    return sum;
}

Console.WriteLine("Введите количество элементов в массиве");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

InitArr(arr);
PrintArr(arr);

Console.WriteLine(CountEvenNum(arr));