using AutoMapper;
using Lista_obecności.Data;
using Lista_obecności.DTO;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Mappers
{
    public class ApplicationMapper 
    {
        public IMapper mMapper;

        public ApplicationMapper()
        {
            mMapper = new MapperConfiguration(config =>
              {
                  config.CreateMap<Users, UsersDTO>()
                  .ReverseMap();
                  config.CreateMap<Workers, WorkersDTO>()
                  .ReverseMap();
                  config.CreateMap<FreeDays, FreeDaysDTO>()
                  .ReverseMap();
              }).CreateMapper();
        }

        public UsersDTO Map(Users users) => mMapper.Map < UsersDTO > (users);
        public IEnumerable<UsersDTO> Map(IEnumerable<IdentityUser> users) => mMapper.Map<IEnumerable<UsersDTO>>(users);
        public Users Map(UsersDTO users) => mMapper.Map<Users>(users);
        public IEnumerable<Users> Map(IEnumerable<UsersDTO> users) => mMapper.Map<IEnumerable<Users>>(users);

        public WorkersDTO Map(Workers workers) => mMapper.Map<WorkersDTO>(workers);
        public IEnumerable<WorkersDTO> Map(IEnumerable<Workers> workers) => mMapper.Map<IEnumerable<WorkersDTO>>(workers);
        public Workers Map(WorkersDTO workers) => mMapper.Map<Workers>(workers);
        public IEnumerable<Workers> Map(IEnumerable<WorkersDTO> workers) => mMapper.Map<IEnumerable<Workers>>(workers);

        public FreeDaysDTO Map(FreeDays freeDays) => mMapper.Map<FreeDaysDTO>(freeDays);
        public IEnumerable<FreeDaysDTO> Map(IEnumerable<FreeDays> freeDays) => mMapper.Map<IEnumerable<FreeDaysDTO>>(freeDays);
        public FreeDays Map(FreeDaysDTO freeDays) => mMapper.Map<FreeDays>(freeDays);
        public IEnumerable<FreeDays> Map(IEnumerable<FreeDaysDTO> freeDays) => mMapper.Map<IEnumerable<FreeDays>>(freeDays);
    }
}
