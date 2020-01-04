using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;


namespace UICMA.Repository
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(UICMAContext context) : base(context)
        {

        }
    }
}
