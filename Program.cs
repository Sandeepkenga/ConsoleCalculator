

using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            double answer = 0;
            
            Console.WriteLine("Type 'start' to begin calculator and to do another operation");
            Console.WriteLine("When you are done type 'end' ");
            Console.WriteLine("type 'history' if you want to see all your previous answers");

            List<double> answers = new List<double>();

                while(true)
                {  
                    string written = Console.ReadLine();

                    if (written == "history" || written == "History")
                    {
                        if (answers.Count > 0)
                        {
                            for (int i = 0; i < answers.Count ; i++)
                            {
                                Console.WriteLine(answers[i]);
                            }
                        }
                    }
                    if (written == "end" ||written == "End")
                    {
                        Environment.Exit(0);
                    }

                    
                    if (written == "start" || written == "Start")
                    {
                        
                        if (Console.ReadLine() == "end" || Console.ReadLine() == "End")
                        {
                            Environment.Exit(0);
                        }
                        
                        
                        Console.WriteLine("What operation do you want? + - * /");
                        String oper = Console.ReadLine();

                        Console.WriteLine("Type your two numbers in");
                            
                        double x = Convert.ToDouble(Console.ReadLine());
                        double y = Convert.ToDouble(Console.ReadLine());
                        if (oper == "+")
                        {
                            answer = x + y;
                            Console.WriteLine(answer);
                            answers.Add(answer);
                        }
                            

                        if (oper == "-")
                        {
                            answer = x - y;
                            Console.WriteLine(answer);
                            answers.Add(answer);
                        }


                        if (oper == "*")
                        {
                            answer = x * y;
                            Console.WriteLine(answer);
                            answers.Add(answer);
                        }


                        if (oper == "/")
                        {
                            
                            answer = x / y;
                            Console.WriteLine( answer);
                            answers.Add(answer);
                        
                        }
                        
                            
                        
                            
                            
                            
                    }
                            
                       written = "";
            
                }
            
        }
    }
}
