using System;

namespace Mailbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // make empty array of size <whatever>
            // while true:
            // ask for command
            // if command == "save":
            //// get message
            //// add into array
            //// print ID
            // else if retrieve:
            //// get ID
            //// print message
            // else if exit:
            //// break
            // else:
            //// go back to input

            int mailboxSize = 10;
            string[] mailbox = new string[mailboxSize];
            string command = ""; // place to put what the user wants to do
            // int nextID = 0; // where to put the next saved message

            while (true) // do until I tell you to stop
            {
                Console.WriteLine("Please type \"save\", \"retrieve\", or \"exit\".");
                command = Console.ReadLine(); // grabs user input and stores it as command
                if (command == "save")
                {
                    // prompt user for message
                    // ask user for desired message slot
                    // put message in slot

                    Console.WriteLine("Please enter your message:");
                    string message = Console.ReadLine();

                    Console.WriteLine("Please choose an ID for the message (0-9).");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Okay! Your message ID is " + ID);
                    mailbox[ID] = message;
                }
                else if (command == "retrieve")
                {
                    Console.WriteLine("Please choose an ID to retrieve (0-9).");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Your message is: " + mailbox[ID]);
                }
                else if (command == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That wasn't one of the things I asked you for.  Try again?");
                }
                //for (int i = 0; i < mailboxSize; i++)
                //{
                //    Console.WriteLine(i);
                //    Console.WriteLine(mailbox[i]);
                //} 
            }
        }
    }
}



