using System;
using System.Diagnostics;
using System.IO;

namespace MyProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "mypage.html");
            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
            else
            {
                Console.WriteLine($"File not found: {filePath}");
            }
        }
    }
}
