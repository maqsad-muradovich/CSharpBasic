using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Crud.Models;

namespace PhoneBook.Crud.Services
{
    internal class PhoneBookService
    {
        public PhoneBookModel[] PhoneBooks { get; set; } = new PhoneBookModel[10];

        public PhoneBookService()
        {
            PhoneBooks[0] = new PhoneBookModel
            {
                Id = 1,
                Name = "Maqsad",
                Phone = "1234567890"
            };
            
            PhoneBooks[1] = new PhoneBookModel
            {
                Id = 2,
                Name = "Nurhissa",
                Phone = "1234567891"
            };
            
            PhoneBooks[2] = new PhoneBookModel
            {
                Id = 3,
                Name = "Sanjar",
                Phone = "1234567892"
            };
        }

        public void Create(string nameinput, string phoneinput)
        {
            int nextId = PhoneBooks.Count(p => p != null);

            if (nextId >= PhoneBooks.Length)
            {
                Console.WriteLine("Yangi yozuv qoshib bolmadi. Massiv allaqachon tolgan.");
                return;
            }

            PhoneBooks[nextId] = new PhoneBookModel
            {
                Id = nextId+1,
                Name = nameinput,
                Phone = phoneinput
            };
        }

        public void ReadAllPhoneBooks()
        {
            for (int iteration = 0; iteration < PhoneBooks.Length; iteration++)
            {
                PhoneBookModel phoneBook = PhoneBooks[iteration];

                if (phoneBook is not null)
                {
                    Console.WriteLine($"{phoneBook.Id} - {phoneBook.Name} {phoneBook.Phone}");
                }
            }
        }

        public void ReadById(int inputid)
        {
            for (int iteration = 0; iteration < PhoneBooks.Length; iteration++)
            {
                PhoneBookModel phoneBook = PhoneBooks[iteration];

                if (phoneBook is not null && phoneBook.Id == inputid)
                {
                    Console.WriteLine($"{phoneBook.Id} - {phoneBook.Name} {phoneBook.Phone}");
                    return;
                }
            }
            Console.WriteLine($"{id} identifikatorli foydalanuvchi topilmadi.");
        }

        public void DeletePhoneBookById(int id)
        {
            for (int i = 0; i < PhoneBooks.Length; i++)
            {
                if (PhoneBooks[i] != null && PhoneBooks[i].Id == id)
                {
                    PhoneBooks[i] = null;
                    Console.WriteLine("Foydalanuvci o'chirildi.");
                    return;
                }
            }
            Console.WriteLine($"{id} identifikatorli foydalanuvchi topilmadi.");
        }
    }
}