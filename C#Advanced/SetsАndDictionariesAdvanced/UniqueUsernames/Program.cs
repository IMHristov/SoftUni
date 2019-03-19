﻿using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                userNames.Add(user);

            }
            foreach (var user in userNames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
