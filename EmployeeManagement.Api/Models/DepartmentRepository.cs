using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        
        public async Task<Department> GetDepartment(int id)
        {
            return appDbContext.Departments.FirstOrDefault(d => d.DepartmentId == id);
        }
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return appDbContext.Departments;
        }
    }
}
