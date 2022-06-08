using ExpenseTracker.Application.DTOs;
using MediatR;

namespace ExpenseTracker.Application.Command
{
    public class CreateUserCommand : IRequest<Response<UserCommandResponseDTO>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
