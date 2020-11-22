using AutoMapper;
using Lista_obecności.DTO;
using Lista_obecności.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data
{
    public class ApplicationViewModelMapper
    {
        public IMapper mMapper;

        public ApplicationViewModelMapper()
        {
            mMapper = new MapperConfiguration(config =>
            {
                config.CreateMap<UsersDTO, UsersViewModel>()
                .ReverseMap();
                config.CreateMap<WorkersDTO, Workers>()
                .ReverseMap();
                config.CreateMap<FreeDaysDTO, FreeDays>()
                .ReverseMap();
            }).CreateMapper();
        }

        public UsersViewModel Map(UsersDTO users) => mMapper.Map<UsersViewModel>(users);
        public IEnumerable<UsersViewModel> Map(IEnumerable<UsersDTO> users) => mMapper.Map<IEnumerable<UsersViewModel>>(users);
        public UsersDTO Map(UsersViewModel users) => mMapper.Map<UsersDTO>(users);
        public IEnumerable<UsersDTO> Map(IEnumerable<UsersViewModel> users) => mMapper.Map<IEnumerable<UsersDTO>>(users);

        public WorkersViewModel Map(WorkersDTO workers) => mMapper.Map<WorkersViewModel>(workers);
        public IEnumerable<WorkersViewModel> Map(IEnumerable<WorkersDTO> workers) => mMapper.Map<IEnumerable<WorkersViewModel>>(workers);
        public WorkersDTO Map(WorkersViewModel workers) => mMapper.Map<WorkersDTO>(workers);
        public IEnumerable<WorkersDTO> Map(IEnumerable<WorkersViewModel> workers) => mMapper.Map<IEnumerable<WorkersDTO>>(workers);

        public FreeDaysViewModel Map(FreeDaysDTO freeDays) => mMapper.Map<FreeDaysViewModel>(freeDays);
        public IEnumerable<FreeDaysViewModel> Map(IEnumerable<FreeDaysDTO> freeDays) => mMapper.Map<IEnumerable<FreeDaysViewModel>>(freeDays);
        public FreeDaysDTO Map(FreeDaysViewModel freeDays) => mMapper.Map<FreeDaysDTO>(freeDays);
        public IEnumerable<FreeDaysDTO> Map(IEnumerable<FreeDaysViewModel> freeDays) => mMapper.Map<IEnumerable<FreeDaysDTO>>(freeDays);
    }

}
