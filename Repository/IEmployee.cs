using firstapi.Models;
namespace firstapi.Repository
{

    public interface IEmployee<Employee>
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee e);
        void UpdateEmployee(int id, Employee e);
        Employee GetEmpById(int id);
        void DeleteEmployee(int id);
    }
}