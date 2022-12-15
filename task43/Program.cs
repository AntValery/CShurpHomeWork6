/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void PrintTheIntersectionPoint(){
    double[] b = new double[2];
    double[] k = new double[2];
    
    for(int i = 0; i < b.Length; i++){
        Console.Write("Enter b" + (i+1) + ": ");
        b[i] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter k" + (i+1) + ": ");
        k[i] = Convert.ToDouble(Console.ReadLine());
    }

    double x = (b[1] - b[0])/(k[0] - k[1]);
    double y = k[0] * x + b[0];

    Console.WriteLine($"({x}; {y})");
}

PrintTheIntersectionPoint();


