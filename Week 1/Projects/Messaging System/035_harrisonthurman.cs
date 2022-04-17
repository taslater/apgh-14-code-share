            string[] messages = new string[3];
            int index = 1;
            int on = 1;
            while (on == 1)
            {
                Console.WriteLine("Please make a choice ");
                Console.WriteLine("A. Save a message ");
                Console.WriteLine("B. Retrieve a message ");
                Console.WriteLine("C. Delete a Message");
                Console.WriteLine("D. Exit ");
                string reply = Console.ReadLine().ToLower();

                if (reply == "a")
                {
                    if (index > 2)
                    {
                        Console.WriteLine("Your messages are full");
                    }
                    else if (index <= 2)
                    {
                        Console.WriteLine("Please leave a message ");
                        messages[index] = Console.ReadLine();
                        Console.WriteLine("Your message number is: " + index);
                        index = index + 1;
                    }
                }
                else if (reply == "b")

                {
                    Console.WriteLine("Please give a message number ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (id > index)
                    {
                        Console.WriteLine("Your message doesn't exists");
                    }
                    else
                    {
                        Console.WriteLine(messages[id]);
                    }
                }

                else if (reply == "c")
                {
                    Console.WriteLine("What is the number of the message you would like to delete?");
                    int id = Convert.ToInt32(Console.ReadLine());
                    messages[id] = "This message doesn't exist2";
                    Console.WriteLine("Your message has been deleted");
                }

                else if (reply == "d")
                {
                    on = 0;
                }
