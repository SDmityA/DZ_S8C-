﻿// ##############___ДЗ Семинар 8___#################
// ***************___Задача 1__*********************
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int Res = num%100;
// int ResF=Res/10;
// Console.WriteLine (ResF);
//******************Конец***************************






































































































// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// *********************************************************************************************************
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 68 -> 8
// 12-> 2
// 85 -> 8
// int num = new Random().Next(10,100);
// Console.WriteLine(num);
// int ten = num/10;
// int one = num%10;
// if (ten>one)
// {
//     Console.WriteLine (ten);
// }
// else Console.WriteLine (one);
// ***********************************************************************************************************
// ***********************************************************************************************************
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// int num = new Random().Next(100,1000);
// Console.WriteLine (num);
// int hun = num/100;
// int one = num%10;
// int res = (hun*10)+one;
// Console.WriteLine(res);
//*************************************************************************************************************
//*************************************************************************************************************
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// int num1 =new Random().Next(1,10);
// Console.WriteLine(num1);
// int num2 = new Random().Next(10,100);
// Console.WriteLine(num2);
// int res = num2%num1;
// if (res == 0)
//     {
//         Console.WriteLine("Кратно");
//     }
//     else Console.WriteLine("Остаток " + res);
//*************************************************************************************************************
//*************************************************************************************************************
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
// int num =new Random().Next(1,1000);
// Console.WriteLine(num);
// if ((num%7==0) && (num%23==0))
// {
//     Console.WriteLine("Кратно");
// }
// else Console.WriteLine("Нет");
//*************************************************************************************************************
//*************************************************************************************************************
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
// int num1 =new Random().Next(1,1000);
// Console.WriteLine(num1);
// int num2 = new Random().Next(1,1000);
// Console.WriteLine(num2);
// if ((num1== num2*num2)||(num2==num1*num1))
// {
//     Console.WriteLine("Да");
// }
// else Console.WriteLine ("Нет");
//*************************************************************************************************************
//*************************************************************************************************************
