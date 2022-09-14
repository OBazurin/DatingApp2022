using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;

namespace API.Tests
{
    public class DummyRepo : IUserRepository
    {
        private IUserRepository _mock;

        public DummyRepo(IUserRepository mock)
        {
            _mock = mock;
        }
        public Task<MemberDto> GetMemberAsync(string name)
        {
            return _mock.GetMemberAsync(name);
        }

        public Task<IEnumerable<MemberDto>> GetMembersAsync()
        {
           return _mock.GetMembersAsync();
        }

        public Task<AppUser> GetUserByIdAsync(int id)
        {
            return _mock.GetUserByIdAsync(id);
        }

        public Task<AppUser> GetUserByUserNameAsync(string name)
        {
            return _mock.GetUserByUserNameAsync(name);
        }

        public Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return _mock.GetUsersAsync();
        }

        public Task<bool> SaveAllAsync()
        {
            return _mock.SaveAllAsync();
        }

        public void Update(AppUser user)
        {
            _mock.Update(user);
        }
    }
}