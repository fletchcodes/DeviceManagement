using System.Runtime.Serialization;

namespace DeviceAccess.Interface.Contracts
{
	[DataContract]
	public class NewDevice
	{
		[DataMember]
		public string DeviceId { get; set; }

		[DataMember]
		public string DeviceName { get; set; }
		
		[DataMember] 
		public double Latitude { get; set; }
		
		[DataMember] 
		public double Longitude { get; set; }
		
		[DataMember] 
		public string SiteName { get; set; }

		[DataMember] 
		public string SiteLocation { get; set; }
	}
}
