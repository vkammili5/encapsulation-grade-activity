using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationGradeActivity.Models
{
    public class Student
    {
        public string Name { get; private set; }
        public char Grade { get; private set; }
        
        private int _group;
        private string _secretNickName = "MySecretNickName";
        char[] arr= new char[6];
        
        public Student(string name, char grade, int group)
        {
            Name = name;
            Grade = grade;
            _group = group;
            arr[0] = 'F';
            arr[1] = 'E';
            arr[2] = 'D';
            arr[3] = 'C';
            arr[4] = 'B';
            arr[5] = 'A';
            int IndexGrade;
            IndexGrade = Array.IndexOf(arr, Grade);
            if (IndexGrade == -1)
                throw new ArgumentNullException("Please enter a valid grade :");
                
        }

        
        public void Upgrade()
        {
            int IndexGrade;
            IndexGrade = Array.IndexOf(arr, Grade);
            IndexGrade += 1;
            Grade = arr[IndexGrade];
            Console.WriteLine("The upgraded grade is " + Grade);
        }
        public void Downgrade()
        {
            int IndexGrade;
            IndexGrade = Array.IndexOf(arr, Grade);
            IndexGrade -= 1;
            Grade = arr[IndexGrade];
            Console.WriteLine("The downgraded grade is " + Grade);
        }



    }
}
