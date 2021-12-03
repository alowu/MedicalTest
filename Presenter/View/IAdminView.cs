using Model.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.View
{
	public interface IAdminView
	{
		Patient patient { get; set; }
	}
}
