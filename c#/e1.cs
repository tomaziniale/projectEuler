private void sum3_5_below_1000() 
        { 
            var sum = 0; 
 
 
            for (int i = 1; i < 1000; i++) 
                sum += (i % 3 == 0 || i % 5 == 0) ? i : 0; 
 
 
            Console.WriteLine("sum multiples of 3 or 5 below 1000: " + sum); 
        } 