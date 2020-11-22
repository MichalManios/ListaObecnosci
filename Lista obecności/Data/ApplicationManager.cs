using Lista_obecności.Data.Repository;
using Lista_obecności.DTO;
using Lista_obecności.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data
{
    public class ApplicationManager : IApplicationManager
    {
        private readonly IUsers mIUsers;
        private readonly IWorkers mIWorkers;
        private readonly IFreeDays mIFreeDays;
        private readonly ApplicationMapper mApplicationMapper;

        public ApplicationManager(IUsers IUsers, IFreeDays IFreeDays, IWorkers IWorkers, ApplicationMapper applicationMapper)
        {
            mIUsers = IUsers;
            mIWorkers = IWorkers;
            mIFreeDays = IFreeDays;
            mApplicationMapper = applicationMapper;
        }

        public ICollection<string> GetAllSectionOfWorkers()
        {
            var section=mIWorkers.GetAllSection();
            return section;
        }
        public IEnumerable<WorkersDTO> GetAllWorkers(string filterStringSection)
        {
            var workersEntity = mIWorkers.GetAllWorkers();
            if (!string.IsNullOrEmpty(filterStringSection)) workersEntity = workersEntity.Where(x => x.Section == filterStringSection);

            return mApplicationMapper.Map(workersEntity);
        }

        

        public IEnumerable<FreeDaysDTO> GetAllFreeDays()
        {
            var freeDaysEntity = mIFreeDays.GetAllFreeDays();
            

            return mApplicationMapper.Map(freeDaysEntity);
        }

        public void  AddNewWorker(WorkersDTO workersDTO)
        {
            var worker = mApplicationMapper.Map(workersDTO);
            mIWorkers.AddNew(worker);
        }

        public bool DeleteWorker(WorkersDTO workersDTO)
        {
            var worker = mApplicationMapper.Map(workersDTO);
            return mIWorkers.Delete(worker);
        }

        public bool ModifyWorker(WorkersDTO workersDTO)
        {
            var worker = mApplicationMapper.Map(workersDTO);
            var oldworker = mIWorkers.GetAll().Where(x => x.Id == worker.Id).FirstOrDefault();
            oldworker.Surname = worker.Surname;
            oldworker.Name = worker.Name;
            oldworker.Section = worker.Section;
            oldworker.IsManager = worker.IsManager;
            return mIWorkers.Modify(oldworker);
        }

        public void AddNewFreeDays(FreeDaysDTO freeDaysDTO)
        {
            var freeDay = mApplicationMapper.Map(freeDaysDTO);
            mIFreeDays.AddNew(freeDay);
        }

        public bool DeleteFreeDay(FreeDaysDTO freeDaysDTO)
        {
            var freeDay = mApplicationMapper.Map(freeDaysDTO);
            return mIFreeDays.Delete(freeDay);
        }

        public bool ModifyFreeDay(FreeDaysDTO freeDaysDTO)
        {
            var freeDay = mApplicationMapper.Map(freeDaysDTO);
            var oldfreeday = mIFreeDays.GetAll().Where(x => x.Id == freeDaysDTO.Id).FirstOrDefault();
            oldfreeday.Day = freeDay.Day;
            oldfreeday.Month = freeDay.Month;
            oldfreeday.NameOfHoliday = freeDay.NameOfHoliday;
            return mIFreeDays.Modify(oldfreeday);
        }

        public IEnumerable<UsersDTO> GetAllUsers()
        {
            var usersEntity = mIUsers.GetAllUsers();


            return mApplicationMapper.Map(usersEntity);
        }
        public void AddNewUser(UsersDTO usersDTO)
        {
            var user = mApplicationMapper.Map(usersDTO);
            mIUsers.AddNew(user);
        }

        public bool DeleteUser(UsersDTO usersDTO)
        {
            var user = mApplicationMapper.Map(usersDTO);
            return mIUsers.Delete(user);
        }

        public bool ModifyUser(UsersDTO usersDTO)
        {
            var user = mApplicationMapper.Map(usersDTO);
            return mIUsers.Modify(user);
        }
    }
}
