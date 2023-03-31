namespace ChallengeApp
{
    
    public class Employee
    {
        private List<int> score = new List<int>();

        private List<int> dockscore = new List<int>();
        


        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        


        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public int Result => score.Sum() - dockscore.Sum();
        public int DockScore => dockscore.Sum();
        public void AddScore(int number)
        {
            score.Add(number); 
        }
        public void AddDockScore(int number)
        
        {
            dockscore.Add(number); 
        }

    }

}