namespace HomeWork4.City
{
    internal class City
    {
        //население
        private int population;

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public void IncreasePopulation(int amount)
        {
            population += amount;
        }

        public void DecreasePopulation(int amount)
        {
            if (population - amount >= 0)
            {
                population -= amount;
            }
            else
            {
                Console.WriteLine("Население не может быть меньше 0.");
            }
        }

        //перегрузка +
        public static City operator +(City city, int amount)
        {
            city.Population += amount;
            return city;
        }

        //перегрузка -
        public static City operator -(City city, int amount)
        {
            city.Population -= amount;
            return city;
        }

        //сравнение кол-ва населения  в 2 городах ==
        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }

        //сравнение кол-ва населения  в 2 городах  !=
        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }

        //сравнение кол-ва населения  в 2 городах >
        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        //сравнение кол-ва населения  в 2 городах <
        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }

        //перегрузка Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            City other = (City)obj;
            return Population == other.Population;
        }
    }
}
