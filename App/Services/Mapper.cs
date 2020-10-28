using App.Entities;
using App.Interfaces;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public class Mapper : IMapper
    {
        public UserDto ToUserDto(User user)
        {
            var userDto = new UserDto();
            userDto.Id = user.Id;
            userDto.Name = $"{user.FirstName} {user.LastName}";
            
            var currentDate = DateTime.Now;
            var birthDate = user.BirthDate;           
            userDto.Age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                userDto.Age--;
            }

            return userDto;
        }

        public IEnumerable<UserDto> ToUserDtos(IEnumerable<User> users)
        {
            var userDtos = new List<UserDto>();
            
            foreach (var user in users)
            {
                userDtos.Add(ToUserDto(user));
            }

            return userDtos;
        }
    }
}
