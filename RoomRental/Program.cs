using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRental {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            Console.WriteLine();
            int N = int.Parse(Console.ReadLine());
            Student[] rooms = new Student[10];
            for (int i = 0; i < N; i++) {
                Console.WriteLine($"Estudante #{i+1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("E-Mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                rooms[room] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (rooms[i] != null) {
                    Console.WriteLine($"{i}: {rooms[i]}");
                }
            }
        }
    }
}
