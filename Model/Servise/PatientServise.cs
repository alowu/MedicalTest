using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;
using Model.Servise;

namespace Model.Servise
{
	public class PatientServise : IPatientServise
	{

		private PatientRepository _patientRepository;

		public PatientServise()
		{
			_patientRepository = new PatientRepository();
		}

		private string AddSpace(string str, int len)
		{
			for (int i = 0; i < len; i++)
			{
				str += " ";
			}
			return str;
		}

		private Patient MakeBeautiful(Patient item)
		{
			string fname = item.firstName;
			if (fname.Length < 20)
			{
				fname = AddSpace(fname, 20 - fname.Length);
			}

			string mname = item.middleName;
			if (mname.Length < 20)
			{
				mname = AddSpace(mname, 20 - mname.Length);
			}

			string lname = item.lastName;
			if (lname.Length < 20)
			{
				lname = AddSpace(lname, 20 - lname.Length);
			}

			return new Patient(item.id, fname, mname, lname, item.age, item.sex, item.hasExam);
		}

		private bool isValid(Patient item)
		{
			bool isValid = true;
			if (string.IsNullOrEmpty(item.firstName) && string.IsNullOrWhiteSpace(item.firstName) ||
				string.IsNullOrEmpty(item.middleName) && string.IsNullOrWhiteSpace(item.middleName) ||
				string.IsNullOrEmpty(item.lastName) && string.IsNullOrWhiteSpace(item.lastName) ||
				item.sex.Equals(Sex.Error))
			{
				isValid = false;
			}
			return isValid;
		}

		public bool Create(Patient item)
		{
			bool valid = isValid(item);
			if (valid)
			{
				Patient patient = MakeBeautiful(item);
				return _patientRepository.Create(patient);
			}
			else
			{
				return valid;
			}
		}

		public bool Delete(int id)
		{
			bool result = false;
			bool have = isPatient(id);
			if (have)
			{
				result = _patientRepository.Delete(id);
			}
			return result;
		}

		public bool Update(Patient item)
		{
			bool result = false;
			bool have = isPatient(item.id);
			bool valid = isValid(item);

			if (have && valid)
			{
				Patient patient = MakeBeautiful(item);
				result = _patientRepository.Update(patient);
			}
			
			return result;
		}

		public List<Patient> GetAll()
		{
			return _patientRepository.GetAll();
		}

		public Patient GetPatient(int Id)
		{
			return _patientRepository.GetT(Id);
		}

		public bool isPatient(int Id)
		{
			bool havePatient = true;
			Patient patient = _patientRepository.FindById(Id);
			if (patient == null)
			{
				havePatient = false;
			}
			return havePatient;
		}

		public bool UpdateStatus(int id)
		{
			return _patientRepository.UpdateStatus(id);
		}
	}
}
