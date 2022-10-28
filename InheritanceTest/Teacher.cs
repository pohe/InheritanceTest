using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    public class Teacher : Employee
    {
		private string _subject;

		public string Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}

		//public Teacher() : base(-1, "No name", "")
		//{
		//	_subject = "Ingenting"; 
		//}

		public Teacher(string subject, int id, string name, string mobile) : base(id, name, mobile)
		{
			_subject = subject;
		}

		public override int CalculateSalary()
		{
			if (_subject =="SWD")
			{
				return (int) (_baseSalary * 1.10);
			}
			else
				return _baseSalary;
		}

		public override string ToString()
        {
            return $"Subject {_subject} " + base.ToString();
        }
    }
}
