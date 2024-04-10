using System;
namespace eSimpleBlob.Domain.Entities.Session
{
	public class TokenData
	{
		public string Token { get; set; }
		public string Cookie { get; set; }
		public DateTime ExpireTime { get; set; }
	}
}

