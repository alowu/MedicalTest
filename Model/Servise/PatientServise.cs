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
		public Task<Patient> Create(Patient item)
		{
			return _patientRepository.Create(item);
		}

		public Task<Patient> Delete(int id)
		{
			return _patientRepository.Delete(id);
		}

		public Task<Patient> GetAll()
		{
			return _patientRepository.GetAll();
		}

		public Task<Patient> Update(Patient item)
		{
			return _patientRepository.Update(item);
		}
	}
}
