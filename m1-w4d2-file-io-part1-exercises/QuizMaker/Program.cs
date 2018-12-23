using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using QuizMaker.Classes;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
                bool success = false;
                string directory = Environment.CurrentDirectory;
                string fileName = "sample-quiz-file.txt";
            //C:\Users\eulry\Desktop\repull\c-exercises\m1-w4d2-file-io-part1-exercises\QuizMaker\bin\Debug
            List<Question> questions = new List<Question>();
                int counter = 0;
                int correct = 0;
                int totalCorrect = 0;
                while (!success)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(Path.Combine(directory, fileName)))
                        {
                            while (!sr.EndOfStream)
                            {
                                string[] line = sr.ReadLine().Split('|');
                                questions.Add(new Question(line.ToList()));
                            }
                        }
                        success = true;
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("That file didn't seem to work, is it in the right place? Please try again.");
                    break;
                    }
                }
                foreach (Question question in questions)
                {
                    counter++;
                    Console.WriteLine($"{question.Prompt}");
                    foreach (string answer in question.Answers)
                    {
                        int index = question.Answers.IndexOf(answer) + 1;
                        if (answer.Contains('*'))
                        {
                            correct = index;
                            Console.WriteLine($"{index}) {answer.Substring(0, answer.Length - 1)}");
                        }
                        else
                        {
                            Console.WriteLine($"{index}) {answer}");
                        }
                    }
                    Console.Write("\nYour Answer: ");
                    int response = int.Parse(Console.ReadLine());
                    if (response == correct)
                    {
                        Console.WriteLine("\nRIGHT!");
                        totalCorrect++;
                    }
                    else
                    {
                        Console.WriteLine("\nSorry, that is not correct.");
                    }
                }
                Console.WriteLine($"\nYou got {totalCorrect} answers correct out of {counter} questions asked.");
            }
        }
    }

    
