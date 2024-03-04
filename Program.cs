using System.Text;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1.find duplicate elements in an array

            /*  int[] ar = { 2, 3, 4, 3, 2, 6, 7, 8, 9, 7, 8, 5, 4, 8, 7, 6, 9, 3, 4, 8, 9 };

              for (int i = 0; i < ar.Length; i++)
              {
                  int duplicate = 1;

                  if (ar[i] != 0)
                  {
                      for (int j = i + 1; j < ar.Length; j++)
                      {
                          if (ar[i] == ar[j])
                          {
                              duplicate++;
                              ar[j] = 0;
                          }
                      }
                      Console.WriteLine($"the number {ar[i]} repeated {duplicate} times");
                  }
              }
              Console.ReadLine();
  */







            //// 2. print all unique elements in an array


            //int[] ar = { 1, 1, 2, 2, 3, 3, 6, 7 };

            //for (int i = 0; i < ar.Length; i++)
            //{
            //    bool isUniq = true;


            //    for (int j = 0; j<ar.Length; j++)
            //    {
            //        if (i!=j && ar[i] == ar[j])
            //        {
            //            isUniq= false;
            //            break;
            //        }
            //    }
            //    if (isUniq==true)
            //    {
            //        Console.WriteLine(ar[i]);
            //    }

            //}
            //Console.ReadLine();









            // 3. max element in an array

            /*int[] ar = { 5, 13, 7, 12, 99, 41, 8, 55, 74, 79, 3 };
            int max = 0;
            
            for(int i = 0; i < ar.Length; i++)
            {
                if(ar[i] > max)
                {
                    max = ar[i];
                   
                }
               
                
            }
            Console.WriteLine($"max value of an array is:   {max}");

            Console.ReadLine();*/











            // 4. min value in an array


            /*int[] ar = { 5, 13, 7, 12, 99, 41, 8, 55, 74, 79, 3 };

            int minvalue = ar[0];

            for(int i=1; i<ar.Length; i++) 
            {
                if (ar[i] < minvalue)
                {
                    minvalue = ar[i];
                }
            }  
            Console.WriteLine($"min value of an array is:   {minvalue}");*/

            // another way

            /*Array.Sort(ar);
            for(int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
                break;
            }
            Console.ReadLine();*/










            // 5.pattern program
            /*
                    ********
                    *******
                    ******
                    *****
                    ****
                    ***
                    **
                    *
             */

            /* for(int i = 0; i < 8; i++)
             {
                 for(int j = i; j < 8; j++)
                 {
                     Console.Write(" * ");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();*/








            /* 6.pattern program
             
            *******
            *     *
            *     *
            *     *
            *     *
            *     *
            *******
          
            */


            /*for (int i = 1; i<8; i++)
            {
                for (int j = 1; j<8; j++)
                {
                    if ((i==1   || j==7) || (j==1 || i==7))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();*/













            // 7. reverse of each word in a string

            /* Console.WriteLine("enter a string");
             string word = Console.ReadLine();
             string[] st = word.Split(' ');

             for (int i = st.Length-1; i>=0; i--)
             {
                 Console.Write(st[i] + " ");
             }
             Console.ReadLine();*/












            // 8.sum of digits in a given number

            /* int num = int.Parse(Console.ReadLine());

             int sum = 0;
             while (num > 0)
             {
                 sum+=num%10;
                 num/=10;
             }
             Console.WriteLine(sum);
             Console.ReadLine();*/










            // 9.sum of each row in the matrix

            /*for (int i = 0; i < 6; i++)
            {
                int count = 0;
                for (int j = 0; j < 6; j++)
                {
                    count=count+i;
                    Console.Write(i);
                }
                Console.WriteLine();

                Console.WriteLine(count);
            }
            Console.ReadLine();
*/






            //-------------------------------------------------------------------------//




            // 1.check employee is present or absent (use random)

            /*Random random = new Random();
            int attendence = random.Next(2)+1;
            Console.WriteLine(attendence);
            if (attendence == 1)
            {
                Console.WriteLine("emplpyee is absent");
            }
            else
            {
                Console.WriteLine("employee is present");
            }
            Console.ReadLine();*/











            // 2.calculate daily employee wage

            /* 
             Random random = new Random();
             int hour = random.Next(8);
             int perhour = 20;
             Console.WriteLine($"Employee working time is { hour} hour per day, and employee wage is { hour *perhour}");
             Console.ReadLine();*/











            // 3.part time employee and wage 


            /*  Console.WriteLine("enter employee working time");
              int hour = int.Parse(Console.ReadLine());
              int perhour = 20;
              switch (hour)
              {
                  case 1:
                      Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                      break;
                  case 2:
                      Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                      break;
                  case 3:
                      Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                      break;
                  case 4:
                      Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                      break;
                  case 5:
                      Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                      break;
                  case 6:
                      Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                      break;
                  case 7:
                      Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                      break;
                  case 8:
                      Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                      break;

              }
              Console.WriteLine();

  */









            // 4.  calculate wages for month


            /* Console.WriteLine("enter employee working time");
             int hour = int.Parse(Console.ReadLine());
             int perhour = 20;
             int workingDays = 20;
             int total = hour*perhour*workingDays;
             switch (hour)
             {
                 case 1:
                     Console.WriteLine($"Employee working time is {hour*workingDays} hour per month, and employee wage is {total}");
                     break;
                 case 2:
                     Console.WriteLine($"Employee working time is {hour*workingDays} hour per month, and employee wage is {total}");
                     break;
                 case 3:
                     Console.WriteLine($"Employee working time is {hour*workingDays} hour per month, and employee wage is {total}");
                     break;
                 case 4:
                     Console.WriteLine($"Employee working time is {hour*workingDays} hour per month, and employee wage is {total}");
                     break;
                 case 5:
                     Console.WriteLine($"Employee working time is {hour*workingDays} hour per month, and employee wage is {total}");
                     break;
                 case 6:
                     Console.WriteLine($"Employee working time is {hour*workingDays} hour per month, and employee wage is {total}");
                     break;
                 case 7:
                     Console.WriteLine($"Employee working time is {hour*workingDays} hour per month, and employee wage is {total}");
                     break;
                 case 8:
                     Console.WriteLine($"Employee working time is {hour*workingDays} hour per month, and employee wage is {total}");
                     break;
                 default:
                     Console.WriteLine("enter numbers between 1-8");
                     break;
             }
             Console.ReadLine();*/
































            //string mutable

            /*string s = "BANGALORE";

            StringBuilder sb = new StringBuilder(s);

            sb.Append("GOA");
            Console.WriteLine(sb.Replace('B', 'M'));
            Console.WriteLine(sb.Remove(4, 6));
            Console.ReadLine();
*/















        }
    }
}