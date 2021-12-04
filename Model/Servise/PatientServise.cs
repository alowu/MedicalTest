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

		public bool Create(Patient item)
		{
			// проверка на правильность данных
			bool notValid = false;
			if (string.IsNullOrEmpty(item.firstName) && string.IsNullOrWhiteSpace(item.firstName) ||
				string.IsNullOrEmpty(item.middleName) && string.IsNullOrWhiteSpace(item.middleName) ||
				string.IsNullOrEmpty(item.lastName) && string.IsNullOrWhiteSpace(item.lastName) ||
				item.sex.Equals(Sex.Error))
			{
				return notValid;
			}
			else
			{
				return _patientRepository.Create(item);
			}
		}

		public bool Delete(int id)
		{
			return _patientRepository.Delete(id);
		}

		public bool Update(Patient item)
		{
			return _patientRepository.Update(item);
		}

		public List<Patient> GetAll()
		{
			return _patientRepository.GetAll();
		}
	}
}
