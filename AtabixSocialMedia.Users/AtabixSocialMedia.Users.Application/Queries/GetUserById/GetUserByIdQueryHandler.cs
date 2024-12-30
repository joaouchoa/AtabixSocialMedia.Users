using AtabixSocialMedia.Users.Application.Models;
using AtabixSocialMedia.Users.Core.Repository;
using MediatR;

namespace AtabixSocialMedia.Users.Application.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, BaseResult<GetUserByIdViewModel>>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<BaseResult<GetUserByIdViewModel>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);

            var viewModel = new GetUserByIdViewModel(user.DisplayName, user.BirthDate, user.Header, user.Description, user.Location.Country, user.Contact.Email);

            return new BaseResult<GetUserByIdViewModel>(viewModel);
        }
    }
}
