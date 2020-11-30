using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.Models.DTO;

namespace ASPNETHomework.Services.Interfaces
{
	/// <summary>
	/// Test service:create,full and add in database tables.
	/// </summary>
	public interface ITestService
	{
		IEnumerable<OrderDto> Get();
	}
}
