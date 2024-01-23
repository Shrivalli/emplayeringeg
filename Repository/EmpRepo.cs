using firstapi.Models;

namespace firstapi.Repository
{

    public class EmpRepo : IEmployee<Employee>
    {
        private readonly FisbankDbContext db;
        public EmpRepo(){}

        public EmpRepo(FisbankDbContext _db)
        {
            db=_db;
        }
        public void AddEmployee(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee e=db.Employees.Find(id);
            db.Employees.Remove(e);
            db.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public Employee GetEmpById(int id)
        {
            return  db.Employees.Find(id);
        }

        public void UpdateEmployee(int id, Employee e)
        {
            db.Employees.Update(e);
            db.SaveChanges();

        }
    }
}