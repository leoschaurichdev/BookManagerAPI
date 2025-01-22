using BookManager.Application.Models.InputModel;
using BookManager.Application.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Application.Services
{
    public interface IUserService
    {
        ResultViewModel<int> Insert(CreateUserInputModel model);
    }
}
