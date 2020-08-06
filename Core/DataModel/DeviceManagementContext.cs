using Microsoft.EntityFrameworkCore;

namespace DeviceManagement.Core.DataModel
{
	public class DeviceManagementContext : DbContext
	{
		protected DeviceManagementContext(DbContextOptions<DeviceManagementContext> options) : base (options)
		{
		}
	}
}
