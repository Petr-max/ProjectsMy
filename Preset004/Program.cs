﻿// Решение в группах:
// Напишите программу которая на вход принимает
// трехзначное число и на выходе показывает 
// последнюю цифру этого чила.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int num = 456;

int res = num % 10; // 456 -> 6

int res1 = num / 100; // 456 -> 4.56 -> 4

int res1 = num / 10 % 10; // 45 % 10 = 5 


