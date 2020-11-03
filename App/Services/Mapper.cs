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
        public AwardDto ToAwardDto(Award award)
        {
            var awardDto = new AwardDto()
            {
                Id = award.Id,
                Title = award.Title,
                Description = award.Description,
                ImageUrl = award.Image.Url
            };

            return awardDto;
        }

        public IEnumerable<AwardDto> ToAwardDtos(IEnumerable<Award> awards)
        {
            var awardDtos = new List<AwardDto>();

            foreach (var award in awards)
            {
                awardDtos.Add(ToAwardDto(award));
            }

            return awardDtos;
        }

        public UserDto ToUserDto(User user)
        {
            var userDto = new UserDto
            {
                Id = user.Id,
                Name = $"{user.FirstName} {user.LastName}",
                ImageUrl = user.Image.Url
            };

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
