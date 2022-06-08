using ExpenseTracker.Application.Command;
using ExpenseTracker.Application.DTOs;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Repositories.Command;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseTracker.Application.Handlers.CommandHandlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, Response<UserCommandResponseDTO>>
    {
        private readonly IUserCommandRepository _userCommandRepository = null;
        public CreateUserHandler(IUserCommandRepository userCommandRepository)
        {
            _userCommandRepository = userCommandRepository;
        }

        public async Task<Response<UserCommandResponseDTO>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                FirstName = request.FirstName
            };

            var userSaveResponse = await _userCommandRepository.AddUser(user);

            var saveResponseDTO = new UserCommandResponseDTO()
            {
                UserId = 1
            };

            var res = new Response<UserCommandResponseDTO>(saveResponseDTO, true);
            return res;
        }
    }
}
