using System;
using eSimpleBlob.Domain.Entities.Session;
using MediatR;

namespace eSimpleBlob.Handlers.Requests.Session
{
	public class SetSessionRequest : IRequest<TokenData?>
	{
		public required AuthData AuthData { get; set; }
	}
}

