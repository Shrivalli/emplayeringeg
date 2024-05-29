namespace firstapi.Service
{

    public interface IEmpServ<Employee>
    {
         List<Employee> GetAllEmployees();
        Task AddEmployee(Employee e);
        void UpdateEmployee(int id, Employee e);
        Employee GetEmpById(int id);
        void DeleteEmployee(int id);

        string Message(string name)
        {
            return "Hello "+name;
        }
    }
    }
