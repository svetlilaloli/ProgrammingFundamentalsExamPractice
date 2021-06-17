using System;
using System.Collections.Generic;

namespace BarcodeGenerator
{
    public class Program
    {
        public static void Main()
        {
            string startNumber = Console.ReadLine();
            string endNumber = Console.ReadLine();
            string result = "";
            List<string> barCodes = new List<string>();

            int start = startNumber[0] - '0';
            int end = endNumber[0] - '0';

            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = startNumber[1] - '0'; j <= endNumber[1] - '0'; j++)
                    {
                        if (j % 2 != 0)
                        {
                            for (int k = startNumber[2] - '0'; k <= endNumber[2] - '0'; k++)
                            {
                                if (k % 2 != 0)
                                {
                                    for (int l = startNumber[3] - '0'; l <= endNumber[3] - '0'; l++)
                                    {
                                        if (l % 2 != 0)
                                        {
                                            result = i.ToString() + j + k + l;
                                            barCodes.Add(result);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', barCodes));
        }
    }
}
