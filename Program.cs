using System;

namespace GreetingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập tên từ người dùng
            Console.Write("Ban ten la gi? ");
            string ten = Console.ReadLine();

            // Hiển thị lời chào kèm theo tên
            Console.WriteLine("Xin chao " + ten + " chuc mot ngay moi tot lanh!");
        }
    }
}
