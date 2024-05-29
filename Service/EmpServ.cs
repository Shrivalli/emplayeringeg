using firstapi.Models;
using firstapi.Repository;

namespace firstapi.Service
{

    public class EmpServ : IEmpServ<Employee>
    {

        private readonly IEmployee<Employee> emprepo;
        public EmpServ(){}

        public EmpServ(IEmployee<Employee> _emprepo)
        {
            emprepo=_emprepo;
        }
        public async Task AddEmployee(Employee e)
        {
          await emprepo.AddEmployee(e);
        }

        public void DeleteEmployee(int id)
        {
            emprepo.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return emprepo.GetAllEmployees();
        }

        public Employee GetEmpById(int id)
        {
            return emprepo.GetEmpById(id);
        }

        public void UpdateEmployee(int id, Employee e)
        {
            emprepo.UpdateEmployee(id,e);
        }
    }
}