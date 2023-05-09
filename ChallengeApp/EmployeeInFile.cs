namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                grade = Math.Round(grade);
                writer.Write(grade);
            }

        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
                if (grade >= 0 && grade <= 100)
                {
                    writer.Write(grade);
                }
                else
                {
                    throw new Exception("invalid grade value");
                }
        }

        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(fileName))

                if (float.TryParse(grade, out float result))
                {
                    writer.Write(grade);
                }
                else if (char.TryParse(grade, out char letter))
                {
                    writer.Write(letter);
                }
                else
                {
                    throw new Exception("string it's not float");
                }
        }

        public override void AddGrade(int grade)

        {
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        writer.Write(100);
                        break;
                    case 'B':
                    case 'b':
                        writer.Write(80);
                        break;
                    case 'C':
                    case 'c':
                        writer.Write(60);
                        break;
                    case 'D':
                    case 'd':
                        writer.Write(40);
                        break;
                    case 'E':
                    case 'e':
                        writer.Write(20);
                        break;
                    default:
                        throw new Exception("Wrong Letter");

                }
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var results = this.CountStatistics(gradesFromFile);
            return results;
        }

      

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {

                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades )
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                statistics.Average /= grades.Count;
            }


            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}



