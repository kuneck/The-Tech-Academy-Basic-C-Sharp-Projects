using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Adiciona um estudante ao banco de dados
        using (var context = new StudentContext())
        {
            // Cria o banco de dados se não existir
            context.Database.EnsureCreated();

            // Verifica se o banco já contém dados
            if (!context.Students.Any())
            {
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 1, 1)
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added to database.");
            }
            else
            {
                Console.WriteLine("Database already contains students.");
            }

            // Consulta e exibe os dados dos estudantes
            var students = context.Students.ToList();
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.StudentId}, Name: {s.FirstName} {s.LastName}, DOB: {s.DateOfBirth.ToShortDateString()}");
            }
        }
    }
}
