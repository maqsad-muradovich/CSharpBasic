using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using PhoneBook.Crud.Models;

namespace PhoneBook.Crud.Services
{
    internal class PhoneBookService
    {
        private readonly string _filePath = "file.txt";

        public void Create(string nameinput, string phoneinput)
        {
            int nextId = GetNextId();
            string line = $"{nextId},{nameinput},{phoneinput}";

            using (StreamWriter writer = File.AppendText(_filePath))
            {
                writer.WriteLine(line);
            }
        }

        private int GetNextId()
        {
            int nextId = 1;
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string lastLine = null;
                while (!reader.EndOfStream)
                {
                    lastLine = reader.ReadLine();
                }

                if (lastLine != null)
                {
                    string[] parts = lastLine.Split(',');
                    if (parts.Length > 0 && int.TryParse(parts[0], out nextId))
                    {
                        nextId++;
                    }
                }
            }

            return nextId;
        }

        public void ReadAllPhoneBooks()
        {
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string lastLine = null;
                while (!reader.EndOfStream)
                {
                    lastLine = reader.ReadLine();
                    Console.WriteLine(lastLine);
                }
            }
        }

        public void ReadById(int inputid)
        {
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string lastLine = null;
                while (!reader.EndOfStream)
                {
                    lastLine = reader.ReadLine();
                    if (lastLine != null)
                    {
                        string[] parts = lastLine.Split(',');
                        if (Convert.ToInt32(parts[0]) == inputid)
                        {
                            Console.WriteLine(lastLine);
                        }
                    }
                }
            }
        }

        public void DeletePhoneBookById(int id)
        {
            List<string> updatedLines = new List<string>();

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0 && int.TryParse(parts[0], out int currentId) && currentId == id)
                    {
                        continue;
                    }

                    updatedLines.Add(line);
                }
            }

            File.WriteAllLines(_filePath, updatedLines);
            Console.WriteLine("Foydalanuvchi o'chirildi.");
        }

    }
}