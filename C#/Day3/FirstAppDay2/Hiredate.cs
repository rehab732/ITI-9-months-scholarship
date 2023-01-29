namespace FirstAppDay2
{
    public struct Hiredate
    {
        int day;
        int month;
        int year;

        public Hiredate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return $"( Year {year} : Month {month} : Day{day})";
        }

    }
}

