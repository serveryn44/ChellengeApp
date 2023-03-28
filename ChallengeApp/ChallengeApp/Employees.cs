


using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{


    public class Employee
    {
        private List<int> score = new List<int>();
        private string v1;
        private string v2;
        private string v3;
        private List<int> badscore = new List<int>();
        private string v4;
        private string v5;
        private string v6;

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }



        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public int Result => score.Sum() - badscore.Sum() ;
        public int BadScore => badscore.Sum() ;
        public void AddScore(int number)
            

        { score.Add(number);  }
        public void AddBadScore(int number) { badscore.Add(number);}

       
    }

}