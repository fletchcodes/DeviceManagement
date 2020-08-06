using Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace DeviceManagement.Core.DataModel
{
	public class DeviceManagementContextFactory : IDesignTimeDbContextFactory<DeviceManagementContext>
	{
		public DeviceManagementContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder()
				.AddUserSecrets("2cb2b3c8-6172-43e4-8898-320c19481806")
				.Build();

			var options = new DbContextOptionsBuilder<DeviceManagementContext>()
				.UseSqlServer(configuration[ConfigurationConstants.DeviceManagementConnection]);
		}
	}
}
