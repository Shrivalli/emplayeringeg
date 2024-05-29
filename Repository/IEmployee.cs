using System.Runtime.CompilerServices;
using firstapi.Models;
using Microsoft.AspNetCore.Mvc;
namespace firstapi.Repository
{

    public interface IEmployee<Employee>
    {
        List<Employee> GetAllEmployees();
        Task AddEmployee(Employee e);
        void UpdateEmployee(int id, Employee e);
        Employee GetEmpById(int id);
        void DeleteEmployee(int id);
    }
}