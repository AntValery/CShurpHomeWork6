/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

void CountPositiveNumbers(){
    int countOfPositive = 0;
    string str;
    int temp;
    while((str = Console.ReadLine()) != ""){
        temp = Convert.ToInt32(str);
        if (temp > 0) countOfPositive++;
    }

   Console.WriteLine(countOfPositive);
}

int m = Convert.ToInt32(Console.ReadLine());
CountPositiveNumbers();

