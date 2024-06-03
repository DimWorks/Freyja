using System;

namespace Freyja
{
    public class Diffie_Hellman
    {
        private int private_key;

        public int public_key;
        public int shared_key;
        public int simple_number;
        public int alian_key;
        public int footing;

        public Diffie_Hellman()
        {
            private_key = gen_num();
        }

        int mod(int a, int x, int p)
        {
            int res = 1;
            if (a % p == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    res = (res * a) % p;
                }
            }
            return res;
        }

        bool isSimple(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        int gen_simple()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(2, 1000);

            while (!isSimple(rndNum))
            {
                rndNum = rnd.Next(2, 1000);
            }

            return rndNum;
        }

        int gen_num()
        {
            Random rnd = new Random();
            return rnd.Next(5, 1000);
        }

        public int gen_pub_key()
        {
            return mod(footing, private_key, simple_number);
        }

        public int gen_shared_key()
        {
            return mod(alian_key, private_key, simple_number);
        }

    }
}
