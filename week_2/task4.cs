using System;

public class Student
{
    public string name;
    public int matric;
    public int fsc;
    public int ecat;
    public double aggregate;

    // Parameterized Constructor
    public Student(string n, int m, int f, int e)
    {
        name = n;
        matric = m;
        fsc = f;
        ecat = e;
    }

    // Calculate Aggregate
    public double calculateAggregate()
    {
        aggregate = (matric / 1100.0) * 17 +
                    (fsc / 1200.0) * 50 +
                    (ecat / 400.0) * 33;

        return aggregate;
    }

    // Show Student
    public void showStudent()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Matric Marks: " + matric);
        Console.WriteLine("FSC Marks: " + fsc);
        Console.WriteLine("ECAT Marks: " + ecat);
        Console.WriteLine("Aggregate: " + calculateAggregate());
        Console.WriteLine();
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Student[] students = new Student[100];

        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Calculate Aggregate");
            Console.WriteLine("4. Top Students");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Matric Marks: ");
                int matric = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter FSC Marks: ");
                int fsc = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter ECAT Marks: ");
                int ecat = Convert.ToInt32(Console.ReadLine());

                students[count] = new Student(name, matric, fsc, ecat);

                count++;

                Console.WriteLine("Student Added Successfully!");
                Console.WriteLine();
            }

            else if (choice == 2)
            {
                if (count == 0)
                {
                    Console.WriteLine("No students available.");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        students[i].showStudent();
                    }
                }
            }

            else if (choice == 3)
            {
                for (int i = 0; i < count; i++)
                {
                    students[i].calculateAggregate();

                    Console.WriteLine(students[i].name +
                                      " Aggregate: " +
                                      students[i].aggregate);
                }

                Console.WriteLine();
            }

            else if (choice == 4)
            {
                if (count == 0)
                {
                    Console.WriteLine("No students available.");
                }
                else
                {
                    // Sort students according to aggregate
                    for (int i = 0; i < count - 1; i++)
                    {
                        for (int j = i + 1; j < count; j++)
                        {
                            students[i].calculateAggregate();
                            students[j].calculateAggregate();

                            if (students[j].aggregate > students[i].aggregate)
                            {
                                Student temp = students[i];
                                students[i] = students[j];
                                students[j] = temp;
                            }
                        }
                    }

                    int top = count;

                    if (top > 3)
                    {
                        top = 3;
                    }

                    Console.WriteLine("===== TOP STUDENTS =====");

                    for (int i = 0; i < top; i++)
                    {
                        students[i].showStudent();
                    }
                }
            }

            else if (choice == 5)
            {
                Console.WriteLine("Program ended.");
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }

        } while (choice != 5);
    }
}