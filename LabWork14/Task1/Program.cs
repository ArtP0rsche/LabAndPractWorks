﻿using System.Text.RegularExpressions;

Console.WriteLine("Введите номер телефона (например: +7(9xx)xxx-xx-xx)");
string input = Console.ReadLine();
string pattern = @"^(\+7|8)\(9\d{2}\)\d{3}(-\d{2}){2}$";

Regex regex = new(pattern);
if (regex.IsMatch(input))
    Console.WriteLine("Номер введён верно");
else
    Console.WriteLine("Введён некорректный номер телефона");