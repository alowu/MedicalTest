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
				return _patientRepository.Create(item);
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
				result = _patientRepository.Update(item);
			}
			
			return result;
		}

		public List<Patient> GetAll()
		{
			return _patientRepository.GetAll();
		}

		public Patient GetPatient(int Id)
		{
			throw new NotImplementedException();
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
	}
}
