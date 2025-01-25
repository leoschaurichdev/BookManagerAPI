
using BookManager.Application.Models.ViewModel;
using BookManager.Core.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
            var model = UserViewModel.FromEntity(user);

            if (model == null)
            {
                return ResultViewModel<UserViewModel>.Error("Usuário não encontrado.");
            }

            return ResultViewModel<UserViewModel>.Success(model);
        }
    }
}
