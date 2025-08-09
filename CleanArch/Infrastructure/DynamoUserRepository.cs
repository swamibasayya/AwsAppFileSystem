using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DynamoUserRepository : IUserRepository
    {
        public async  Task<User> GetUserByIdAsync(string id)
        {   
            // Call DynamoDB here
            return new User { Id = id, Name = "FromDynamo" };
                
        }
    }
}
