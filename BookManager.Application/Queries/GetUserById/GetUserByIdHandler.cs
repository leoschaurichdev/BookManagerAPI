
using BookManager.Application.Models.ViewModel;
using BookManager.Core.Repositories;
using MediatR;

namespace BookManager.Application.Queries.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, ResultViewModel<UserViewModel>>
    {
        private readonly IUserRepository _repository;
        public GetUserByIdHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<UserViewModel>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetById(request.Id);
            
            if (user == null)
            {
                return ResultViewModel<UserViewModel>.Error("User not found");
            }
            var model = UserViewModel.FromEntity(user);
            return ResultViewModel<UserViewModel>.Success(model);
        }
    }
}
