


namespace ChallengeApp
{


    public class Employee
    {
        private List<int> score = new List<int>();
        private string v1;
        private string v2;
        private string v3;

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }



        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public int Result => score.Sum();

        public void AddScore(int number)

        { score.Add(number); }

    }

}