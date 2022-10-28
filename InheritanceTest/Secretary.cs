using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    public class Secretary: Employee
    {
		private int _typingSpeed;

		public int TypingSpeed
		{
			get { return _typingSpeed; }
			set { _typingSpeed = value; }
		}

		public Secretary(int id, string name, string mobile, int typingSpeed) :base(id, name, mobile)
		{
			_typingSpeed = typingSpeed;
		}

        public override int CalculateSalary()
        {
			if (_typingSpeed > 500)
			{
				return _baseSalary * 2;
			}
			else
				return _baseSalary; 
        }

        public override string ToString()
		{
			return $"Typingspeed {_typingSpeed} " + base.ToString(); 
		}

    }
}
