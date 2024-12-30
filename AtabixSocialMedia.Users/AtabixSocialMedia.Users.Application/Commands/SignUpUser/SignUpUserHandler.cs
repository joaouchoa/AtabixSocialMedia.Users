using AtabixSocialMedia.Users.Application.Commands.SingUpUser;
using AtabixSocialMedia.Users.Application.Models;
using AtabixSocialMedia.Users.Core.Repository;
using MediatR;

namespace AtabixSocialMedia.Users.Application.Commands.SignUpUser
{
    public class SignUpUserHandler : IRequestHandler<SignUpUserCommand, BaseResult<Guid>>
    {
        private readonly IUserRepository _userRepository;
        public SignUpUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<BaseResult<Guid>> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.ToEntity();

            await _userRepository.AddAsync(user);

            return new BaseResult<Guid>(user.Id);
        }
    }
}
