namespace Class
{
    public class Class1
    {
        public int Fnum {get; set;}

        public int Snum { get; set; }

        public int Sub()
        {
            int res;
            res = Fnum - Snum;
            return res;
        }
        public int div()
        {
            int res;
            if (Fnum == 0 || Snum == 0)
            {
                return 0;
            }
            else
            {
                res = Fnum / Snum;
                return res;
            }

        }
        public int mul()
        {
            int res;
            res = Fnum * Snum;
            return res;
        }

    }
}
