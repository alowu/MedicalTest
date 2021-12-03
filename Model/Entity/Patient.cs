using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
	public class Patient
	{
		public int id
		{
			get;
			set;
		}

		public string firstName
		{ 
			get;
			set;
		}

		public string middleName
		{
			get;
			set;
		}

		public string lastName
		{
			get;
			set;
		}

		public int age
		{
			get;
			set;
		}

		public Sex sex
		{
			get;
			set;
		}

		public bool hasExam
		{
			get;
			set;
		}
	}
}
