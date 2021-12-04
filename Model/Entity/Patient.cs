using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
	public class Patient
	{
		public Patient(int id, string firstName, string middleName, string lastName, int age, Sex sex, bool hasExam)
		{
			this.id = id;
			this.firstName = firstName;
			this.middleName = middleName;
			this.lastName = lastName;
			this.age = age;
			this.sex = sex;
			this.hasExam = hasExam;
		}

		public Patient(string firstName, string middleName, string lastName, int age, Sex sex)
		{
			this.firstName = firstName;
			this.middleName = middleName;
			this.lastName = lastName;
			this.age = age;
			this.sex = sex;
		}

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

		public override string ToString()
		{
			return id.ToString() + " " +
				firstName.ToString() + " " +
				middleName.ToString() + " " +
				lastName.ToString() + " " +
				age.ToString() + " " +
				sex.ToString() + " " + 
				hasExam.ToString();
		}
	}
}