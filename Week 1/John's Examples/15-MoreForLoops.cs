            Console.WriteLine("While loop: ");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }

            Console.WriteLine("For loop: ");
            for(int i = 0; i < 10; i = i + 1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For loop that counts backwards");
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For loop that counts by threes");
            for(int i = 0; i < 10; i = i + 3)
            {
                Console.WriteLine(i);
            }
