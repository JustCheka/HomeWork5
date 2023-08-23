void InitArr(double[] arr){
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = Math.Round(rand.NextDouble() * 20, 2);
    }
}

void PrintArr(double[] arr){
    foreach (var el in arr){
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

double FindMaxEl(double[] arr){
    double max = arr[0];
    foreach (var el in arr){
        if (el > max) max = el;
    }
    return max;
}

double FindMinEl(double[] arr){
    double min = arr[0];
    foreach(var el in arr){
        if (el < min) min = el;
    }
    return min;
}

Console.WriteLine("Введите количество элементов в массиве");
int n = int.Parse(Console.ReadLine());

double[] arr = new double[n];

InitArr(arr);
PrintArr(arr);
double min = FindMinEl(arr);
double max = FindMaxEl(arr);
Console.WriteLine($"{max} - {min} = {Math.Round(max - min, 2)}");