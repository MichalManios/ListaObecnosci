using Lista_obecności.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data
{
    public interface IApplicationManager
    {
        IEnumerable<WorkersDTO> GetAllWorkers(string filterStringSection);


        IEnumerable<FreeDaysDTO> GetAllFreeDays();


        void AddNewWorker(WorkersDTO workersDTO);


        bool DeleteWorker(WorkersDTO workersDTO);


        bool ModifyWorker(WorkersDTO workersDTO);

        ICollection<string> GetAllSectionOfWorkers();

        void AddNewFreeDays(FreeDaysDTO freeDaysDTO);


        bool DeleteFreeDay(FreeDaysDTO freeDaysDTO);


        bool ModifyFreeDay(FreeDaysDTO freeDaysDTO);

        IEnumerable<UsersDTO> GetAllUsers();
        void AddNewUser(UsersDTO usersDTO);


        bool DeleteUser(UsersDTO usersDTO);


        bool ModifyUser(UsersDTO usersDTO);
        
    }
}
