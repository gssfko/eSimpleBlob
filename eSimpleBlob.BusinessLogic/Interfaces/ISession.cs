using System;
using eSimpleBlob.Domain.Entities.Session;

namespace eSimpleBlob.BusinessLogic.Interfaces
{
    public interface ISession
    {
        Task<TokenData> CreateSession(AuthData authData);
    }
}

