using System;
using eSimpleBlob.BusinessLogic.Interfaces;
using eSimpleBlob.Domain.Entities.Session;
using eSimpleBlob.Handlers.Requests;
using eSimpleBlob.Handlers.Requests.Session;
using MediatR;

namespace eSimpleBlob.Handlers.RequestHandlers.Session
{
	public class SetSessionHandler : IRequestHandler<SetSessionRequest, TokenData?>
    {
		private readonly ISession _sessionRepository;

        public SetSessionHandler(ISession sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public async Task<TokenData?> Handle(SetSessionRequest request, CancellationToken cancellationToken)
        {
            // First validate the request
            return await _sessionRepository.CreateSession(request.AuthData);
        }
    }
}

