using App.Entities;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Interfaces
{
    public interface IMapper
    {
        public UserDto ToUserDto(User user);
        public IEnumerable<UserDto> ToUserDtos(IEnumerable<User> users);
    }
}
