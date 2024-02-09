using Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Employee_App.Mappers;

namespace Employee_App.Models.Employer
{
    public class EmployerService : IEmployerService
    {
        private readonly AppDbContext _context;

        public EmployerService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EmployerModel> GetAllEmployers()
        {
            return _context.Employers
                .Select(employer => EmployerMapper.FromEntity(employer)).ToList();
        }

        public EmployerModel GetEmployerById(int employerId)
        {
            var entity = _context.Employers
                .FirstOrDefault(e => e.EmployerId == employerId);

            return entity != null ? EmployerMapper.FromEntity(entity) : null;
        }

        public void AddEmployer(EmployerModel employer)
        {
            _context.Employers.Add(EmployerMapper.ToEntity(employer));
            _context.SaveChanges();
        }

        public void UpdateEmployer(int id, EmployerModel employer)
        {
            _context.Employers.Update(EmployerMapper.ToEntity(employer));
            _context.SaveChanges();
        }

        public void DeleteEmployer(int employerId)
        {
            var entity = _context.Employers.Find(employerId);
            if (entity != null)
            {
                _context.Employers.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
