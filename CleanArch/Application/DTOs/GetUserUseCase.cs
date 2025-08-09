using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class GetUserUseCase: IUserRepository
    {
        private readonly IUserRepository repository;

        public GetUserUseCase(IUserRepository repository)
        {
            this.repository = repository;
        }

        public Task<User> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
