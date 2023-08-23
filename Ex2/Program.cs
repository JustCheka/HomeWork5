void InitArr(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(0, 1000);
    }
}

void PrintArr(int[] arr){
    foreach (var el in arr){
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

int SumOfNum(int[] arr){
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2){
        sum += arr[i];
    }
    return sum;
}

Console.WriteLine("Введите количество элемнтов в массиве");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

InitArr(arr);
PrintArr(arr);
Console.WriteLine(SumOfNum(arr));