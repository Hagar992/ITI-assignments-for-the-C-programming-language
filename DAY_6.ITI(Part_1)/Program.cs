using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6.ITI_Part_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  override & new
            //هذا يوضح الفرق بين تجاوز (override) الدالة في الكلاس الأساسي وإخفاء (hide) الدالة في الكلاس الأساسي باستخدام new.
            //override Example
            //public class BaseClass
            //  {
            //      public virtual void Display()
            //      {
            //          Console.WriteLine("Base Class Display");
            //      }
            //  }

            //  public class DerivedClass : BaseClass
            //  {
            //      public override void Display()
            //      {
            //          Console.WriteLine("Derived Class Display");
            //      }
            //  }

            //  class Program
            //  {
            //      static void Main()
            //      {
            //          BaseClass baseClass = new BaseClass();
            //          BaseClass derivedClassAsBase = new DerivedClass();
            //          DerivedClass derivedClass = new DerivedClass();

            //          baseClass.Display();                // Output: Base Class Display
            //          derivedClassAsBase.Display();       // Output: Derived Class Display
            //          derivedClass.Display();             // Output: Derived Class Display
            //      }
            //  }
            // _____________________________________________________________________________________________
            //new Example


            //public class BaseClass
            //  {
            //      public void Display()
            //      {
            //          Console.WriteLine("Base Class Display");
            //      }
            //  }

            //  public class DerivedClass : BaseClass
            //  {
            //      public new void Display()
            //      {
            //          Console.WriteLine("Derived Class Display");
            //      }
            //  }

            //  class Program
            //  {
            //      static void Main()
            //      {
            //          BaseClass baseClass = new BaseClass();
            //          BaseClass derivedClassAsBase = new DerivedClass();
            //          DerivedClass derivedClass = new DerivedClass();

            //          baseClass.Display();                // Output: Base Class Display
            //          derivedClassAsBase.Display();       // Output: Base Class Display
            //          derivedClass.Display();             // Output: Derived Class Display
            //      }
            //  }
            /*
             * باستخدام override:

              عند استدعاء الدالة Display على كائن من النوع DerivedClass أو من النوع BaseClass ولكن يشير إلى DerivedClass، يتم تنفيذ النسخة الجديدة من الدالة (Derived Class Display).
              باستخدام new:

              عند استدعاء الدالة Display على كائن من النوع DerivedClass مباشرة، يتم تنفيذ النسخة الجديدة من الدالة (Derived Class Display).
              عند استدعاء الدالة Display على كائن من النوع BaseClass أو من النوع BaseClass ولكن يشير إلى DerivedClass، يتم تنفيذ النسخة الأصلية من الدالة (Base Class Display).
            

             */

            #endregion
            Console.WriteLine("Enter the number of questions:");
            int n = int.Parse(Console.ReadLine());

            Question[] questions = new Question[n];

            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("Enter question type (MCQ/TorF):");
                string type = Console.ReadLine();

                Console.WriteLine("Enter question body:");
                string body = Console.ReadLine();

                Console.WriteLine("Enter question mark:");
                int mark = int.Parse(Console.ReadLine());

                if (type.ToLower() == "mcq")
                {
                    Console.WriteLine("Enter the number of answers:");
                    int numOfAnswers = int.Parse(Console.ReadLine());
                    string[] answers = new string[numOfAnswers];

                    for (int j = 0; j < numOfAnswers; j++)
                    {
                        Console.WriteLine($"Enter answer {j + 1}:");
                        answers[j] = Console.ReadLine();
                    }

                    questions[i] = new MCQ_Question(body, mark, answers);
                }
                else if (type.ToLower() == "torf")
                {
                    questions[i] = new TorFQuestion(body, mark);
                }
                else
                {
                    Console.WriteLine("Invalid question type. Please enter either 'MCQ' or 'TorF'.");
                    i--; 
                }
            }

            Console.WriteLine("\nQuestions entered:");
            foreach (var question in questions)
            {
                Console.WriteLine(question.ToString());
                Console.WriteLine();
            }
            //______________________________________________________________________________________________
            if (questions.Length >= 2)
            {
                Console.WriteLine("Comparing the first two questions:");
                if (questions[0].Equals(questions[1]))
                {
                    Console.WriteLine("The first two questions are equal.");
                }
                else
                {
                    Console.WriteLine("The first two questions are not equal.");
                }
            }
            
        }
    }
}
