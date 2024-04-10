using System;
using eSimpleBlob.BusinessLogic.AppCore;
using eSimpleBlob.BusinessLogic.Interfaces;
using eSimpleBlob.Domain.Entities.Session;

namespace eSimpleBlob.BusinessLogic.AppBL
{
	public class SessionBL : MainApi, ISession
	{
		public async Task<TokenData> CreateSession(AuthData authData)
		{
			return await CreateSessionAction(authData);
		}

    }
}

