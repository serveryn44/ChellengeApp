
namespace ChallengeApp
{
    public abstract class Person
    {
        protected Person(string name, string surname, string sex)
            : this(surname,sex)
        {
            this.Name = name;
        }
        public Person(string surname)  
        { 
            this.Surname = surname;
        }
        public Person(string sex, string name)
            : this(name)
        {
            this.Sex = sex;
        }
        public Person(string age, string name, string surname, string sex) 
           : this(surname, sex, name)
        { 
        this.Age = age;
        }                
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public string Age { get; private set; }
    }
}
