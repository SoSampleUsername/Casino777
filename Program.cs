using System;

namespace ETOGO_CASINO
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Main:
            Console.WriteLine("Enter a number what do you want to do?\n1)Check account\n2)Play the game");
            double account = 100;           
            string start_question = Console.ReadLine();
            double q1 = 0;
            bool forWhileQ = true;
            bool endGame = true;
            while (forWhileQ)
            {
                if (!double.TryParse(start_question, out q1))
                {
                    Console.WriteLine("Enter a number what do you want to do?\n1)Check account\n2)Play the game");
                    start_question = Console.ReadLine();
                }
                else if (q1 < 1 || q1 > 2)
                {
                    Console.WriteLine("Enter a number what do you want to do?\n1)Check account\n2)Play the game");
                    start_question = Console.ReadLine();
                }
                else
                {
                    forWhileQ = false;
                }               
            }
            bool acoount_info = true;
            while (acoount_info)
            {
                if (q1 == 1)
                {
                    Console.WriteLine($"Now You have {account}$ on your acoount");
                    acoount_info = false;
                }
                if (q1 == 2) 
                { break; }
            }            
            bool game = true;
            while (game)
            {
              while (account > 0)
              {
                    if (account == 0)
                    {
                        Console.WriteLine("YOU'VE LOS IT ALL");                        
                        break;
                    }
                Random winnumber = new Random();
                int m = winnumber.Next(1, 21);
                Console.WriteLine("Choose a number to bet on (1-20): ");
                string betnumber = Console.ReadLine();
                double bet1 = 0;
                bool forWhile = true;
                while (forWhile)
                {
                    if (!double.TryParse(betnumber, out bet1))
                    {
                        Console.WriteLine("Choose a number to bet on (1-20): ");
                        betnumber = Console.ReadLine();
                    }
                    else if (bet1 <= 0 || bet1 > 20)
                    {
                        Console.WriteLine("Choose a number to bet on (1-20): ");
                        betnumber = Console.ReadLine();
                    }
                    else
                    {
                        forWhile = false;
                    }
                }
                Console.WriteLine("Place amount of money: ");
                string betmoney = Console.ReadLine();
                double bet2 = 0;
                bool forWhile1 = true;
                while (forWhile1)
                {
                    if (!double.TryParse(betmoney, out bet2))
                    {
                        Console.WriteLine("Place correct amount of money:  ");
                        betmoney = Console.ReadLine();
                        forWhile1 = true;
                    }
                    else if (bet2 <= 0)
                    {
                        Console.WriteLine("Too small number. Place correct amount of money: ");
                        betmoney = Console.ReadLine();
                        forWhile1 = true;
                    }
                    else if (bet2 > account)
                    {
                        Console.WriteLine("You don't have enough money. Place correct amount of money: ");
                        betmoney = Console.ReadLine();
                        forWhile1 = true;
                    }
                    else
                    {
                        forWhile1 = false;
                    }
                }
                Console.WriteLine("-------------PROCESSING-------------");
                Console.WriteLine($"The Win Number is: {m}");
                int m_minus = m - 3;
                int m_plus = m + 3;
                    double q2 = 0;
                    if (bet1 == m)
                    {                        
                            Console.WriteLine("YOU WON");
                            account = account + bet2 * 2;
                            Console.WriteLine($"YOUR ACCOUNT IS NOW : {account}$");
                            if (account == 0)
                            {
                                Console.WriteLine("YOU'VE LOS IT ALL");
                                game = false;
                                 Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                 string end_question = Console.ReadLine();
                                 while (endGame)
                                 {
                                        if (!double.TryParse(end_question, out q2))
                                        {
                                            Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                            end_question = Console.ReadLine();
                                        }
                                        else if (q2 < 1 || q2 > 2)
                                        {
                                            Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                            end_question = Console.ReadLine();
                                        }
                                        else
                                        {
                                            endGame = false;
                                        }
                                        bool end_answer = true;
                                        while (end_answer)
                                        {
                                            if (q2 == 1)
                                            {
                                                goto Main;
                                            }
                                            if (q2 == 2)
                                            { break; }
                                        }
                                 }
                                 break;
                            }
                            continue;                        
                    }
                    else if (bet1 >= m_minus && bet1 <= m_plus)
                    {                        
                            Console.WriteLine("YOU NEARLY WON");
                            account = account + bet2 * 0.75;
                            Console.WriteLine($"YOUR ACCOUNT IS NOW : {account}$");
                        if (account == 0)
                        {
                            Console.WriteLine("YOU'VE LOS IT ALL");
                            game = false;
                            Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                            string end_question = Console.ReadLine();
                            while (endGame)
                            {
                                if (!double.TryParse(end_question, out q2))
                                {
                                    Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                    end_question = Console.ReadLine();
                                }
                                else if (q2 < 1 || q2 > 2)
                                {
                                    Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                    end_question = Console.ReadLine();
                                }
                                else
                                {
                                    endGame = false;
                                }
                                bool end_answer = true;
                                while (end_answer)
                                {
                                    if (q2 == 1)
                                    {
                                        goto Main;
                                    }
                                    if (q2 == 2)
                                    { break; }
                                }
                            }
                            break;                            
                        }
                        continue;                        
                    }
                    else if (bet1 >= m_minus - 4 && bet1 <= m_plus + 4)
                    {                        
                            Console.WriteLine("YOU NEARLY WON");
                            account = account + bet2 * 0.33;
                            Console.WriteLine($"YOUR ACCOUNT IS NOW : {account}$");
                        if (account == 0)
                        {
                            Console.WriteLine("YOU'VE LOS IT ALL");
                            game = false;
                            Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                            string end_question = Console.ReadLine();
                            while (endGame)
                            {
                                if (!double.TryParse(end_question, out q2))
                                {
                                    Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                    end_question = Console.ReadLine();
                                }
                                else if (q2 < 1 || q2 > 2)
                                {
                                    Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                    end_question = Console.ReadLine();
                                }
                                else
                                {
                                    endGame = false;
                                }
                                bool end_answer = true;
                                while (end_answer)
                                {
                                    if (q2 == 1)
                                    {
                                        goto Main;
                                    }
                                    if (q2 == 2)
                                    { break; }
                                }
                            }
                            break;
                        }
                        continue;                       
                    }
                    else
                    {                       
                            Console.WriteLine("-------------YOUR BET WAS LOST SOMEWHERE IN DESERT-------------");
                            account = account - bet2;
                            Console.WriteLine($"Your account is now : {account}$");
                        if (account == 0)
                        {
                            Console.WriteLine("YOU'VE LOS IT ALL");
                            game = false;
                            Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                            string end_question = Console.ReadLine();
                            while (endGame)
                            {
                                if (!double.TryParse(end_question, out q2))
                                {
                                    Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                    end_question = Console.ReadLine();
                                }
                                else if (q2 < 1 || q2 > 2)
                                {
                                    Console.WriteLine("So, what's next?\n1)Play again\n2)Kto ti takoy chtobi takoe delat'?!!");
                                    end_question = Console.ReadLine();
                                }
                                else
                                {
                                    endGame = false;
                                }
                                bool end_answer = true;
                                while (end_answer)
                                {
                                    if (q2 == 1)
                                    {
                                        goto Main;
                                    }
                                    if (q2 == 2)
                                    { break; }
                                }
                            }
                            break;
                        }
                        continue;                       
                    }
              }
            }
        }
    }
}