using System;
using PhoneBook.Crud.Models;
using PhoneBook.Crud.Services;

namespace PhoneBook.Crud
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookService phoneBookService = new PhoneBookService();

            while (true)
            {
                Console.WriteLine("Operatsiyani tanlang:\n"+
                                  "1. Qo'shish\n"+
                                  "2. Barcha yozuvlarni ko'rish\n"+
                                  "3. ID boyicha yozuvni topish\n"+
                                  "4. ID boyicha yozuvni o'chirish\n"+
                                  "5. Chiqish");

                Console.Write("Qomandai tanlang: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Ismni kiriting: ");
                        string name = Console.ReadLine();
                        Console.Write("Telefon raqamini kiriting: ");
                        string phone = Console.ReadLine();
                        phoneBookService.Create(name, phone);
                        Console.WriteLine("Foydalanuvchi qo'shildi.");
                        break;
                    case "2":
                        phoneBookService.ReadAllPhoneBooks();
                        break;
                    case "3":
                        Console.Write("ID ni kiriting: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        phoneBookService.ReadById(id);
                        break;
                    case "4":
                        Console.Write("ID ni kiriting: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());;
                        phoneBookService.DeletePhoneBookById(deleteId);
                        break;
                    case "5":
                        Console.WriteLine("Dasturdan tugadi.");
                        return;
                    default:
                        Console.WriteLine("Noto'g'ri buyruq kiritildi)");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}


