using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int selectedOption, count = 1;

            Console.WriteLine("RECTANGLE AREA CALCULATOR");
            Console.WriteLine("****************************");

            try
            {
                Rectangle rect = new Rectangle();

                for (int i = 0; i < count; i++)
                {
                    showOptions();

                    Console.Write("Enter your choice: ");

                    bool isValidSelection = Int32.TryParse(Console.ReadLine(), out selectedOption);

                    if (isValidSelection && selectedOption >= 1 && selectedOption <= 7)
                    {
                        switch (selectedOption)
                        {
                            case 1:
                                Console.Write("Rectangle Length: " + rect.GetLength());
                                count++;
                                break;

                            case 2:
                                Console.Write("Enter Length: ");
                                int length;
                                bool isValidLength = Int32.TryParse(Console.ReadLine(), out length);

                                if (isValidLength && length > 0)
                                {
                                    rect.SetLength(length);
                                }
                                count++;
                                break;

                            case 3:
                                Console.Write("Rectangle Width: " + rect.GetWidth());
                                count++;
                                break;

                            case 4:
                                Console.Write("Enter Width: ");
                                int width;
                                bool isValidWidth = Int32.TryParse(Console.ReadLine(), out width);

                                if (isValidWidth && width > 0)
                                {
                                    rect.SetWidth(width);
                                }
                                count++;
                                break;

                            case 5:
                                Console.Write("Rectangle Perimeter: " + rect.GetPerimeter());
                                count++;
                                break;

                            case 6:
                                Console.Write("Rectangle Area: " + rect.GetArea());
                                count++;
                                break;

                            case 7:
                                Environment.Exit(0);
                                break;
                        }

                        Console.WriteLine("\n");

                    }
                    else
                    {
                        Console.WriteLine("Invalid Option");
                        count++;
                    }
                }
            }            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static void showOptions()
        {
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1. Get Rectangle Length \n" +
                "2. Set Rectangle Length \n" +
                "3. Get Rectangle Width \n" +
                "4. Set Rectangle Width \n" +
                "5. Get Rectangle Perimeter \n" +
                "6. Get Rectangle Area \n" +
                "7. Exit");
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               