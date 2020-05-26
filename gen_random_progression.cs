public List<int> gen_random_progression(int max, Random _random, int num)
        {
            List<int> l = new List<int> { 0 };
            int start_date = _random.Next(0, num / 4);
            int data_size = num - start_date;


            //Generate rank progeression
            for (int i = 0; i < data_size; i++)
            {
                l.Add(_random.Next(1, max));
            }

            //Generates some bottlenecks in Variable progression
            int bottleneck_num = _random.Next(1, 10);
            for (int i = 0; i <= bottleneck_num; i++)
            {
                int rndpp = _random.Next(1, max);
                for (int j = 0; j < 10; j++)
                {
                    int offset = (int)(rndpp / 100);
                    int dummy = rndpp + _random.Next(offset * -1, offset);
                    l.Add(dummy);
                }
            }
            // Generate an inactive period
            for (int i = 0; i < start_date; i++) { l.Add(0); }
            // Sorts the list
            //Adds max value to list
            l.Add(max);
            //Converts list to chartvalues
            return l;
        }