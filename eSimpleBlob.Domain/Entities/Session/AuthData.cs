using System;
namespace eSimpleBlob.Domain.Entities.Session
{
	public class AuthData
	{
		public string Credential { get; set; }
		public string Password { get; set; }
		public string UsedIp { get; set; }
		public DateTime SessionStart { get; set; }
	}
}

