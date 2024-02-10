using Data;
using Data.Entities;
using Employee_App.Models.Employer;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Employee_App.Models.Employer
{
    public class EmployerService : IEmployerService
    {
        private readonly AppDbContext _context;

        public EmployerService(AppDbContext context)
        {
            _context = context;
        }

        public void AddEmployer(EmployerModel employerModel)
        {
            var addressEntity = new AddressEntity
            {
                City = employerModel.City,
                Street = employerModel.Street,
                PostalCode = employerModel.PostalCode
            };
            _context.Addresses.Add(addressEntity);

            var employerEntity = new EmployerEntity
            {
                FirstName = employerModel.FirstName,
                LastName = employerModel.LastName,
                CompanyName = employerModel.CompanyName,
                NIP = employerModel.NIP,
                Address = addressEntity
            };
            _context.Employers.Add(employerEntity);

            _context.SaveChanges();
        }

        public List<EmployerModel> GetAllEmployers()
        {
            return _context.Employers
                .Include(e => e.Address)
                .Select(employer => EmployerMapper.FromEntity(employer))
                .ToList();
        }

        public EmployerModel GetEmployerById(int employerId)
        {
            var employer = _context.Employers
                .Include(e => e.Address)
                .FirstOrDefault(e => e.EmployerId == employerId);

            return employer != null ? EmployerMapper.FromEntity(employer) : null;
        }

        public void UpdateEmployer(int id, EmployerModel employerModel)
        {
            var employer = _context.Employers
                .Include(e => e.Address)
                .FirstOrDefault(e => e.EmployerId == id);

            if (employer != null)
            {
                employer.FirstName = employerModel.FirstName;
                employer.LastName = employerModel.LastName;
                employer.CompanyName = employerModel.CompanyName;
                employer.NIP = employerModel.NIP;

                if (employer.Address != null)
                {
                    employer.Address.City = employerModel.City;
                    employer.Address.Street = employerModel.Street;
                    employer.Address.PostalCode = employerModel.PostalCode;
                }

                _context.SaveChanges();
            }
        }

        public void DeleteEmployer(int employerId)
        {
            var employer = _context.Employers.Find(employerId);
            if (employer != null)
            {
                _context.Employers.Remove(employer);
                _context.SaveChanges();
            }
        }
    }
}