using Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Employee_App.Mappers;

namespace Employee_App.Models.EmploymentHistory
{
    public class EmploymentHistoryService : IEmploymentHistoryService
    {
        private readonly AppDbContext _context;

        public EmploymentHistoryService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EmploymentHistoryModel> GetAllEmploymentHistories()
        {
            return _context.EmploymentHistory
                .Include(eh => eh.Employee)
                .Include(eh => eh.Employer)
                .Select(eh => EmploymentHistoryMapper.FromEntity(eh))
                .ToList();
        }

        public EmploymentHistoryModel GetEmploymentHistoryById(int historyId)
        {
            var entity = _context.EmploymentHistory
                .Include(eh => eh.Employee)
                .Include(eh => eh.Employer)
                .FirstOrDefault(eh => eh.Id == historyId);

            return entity != null ? EmploymentHistoryMapper.FromEntity(entity) : null;
        }

        public void AddEmploymentHistory(EmploymentHistoryModel employmentHistory)
        {
            _context.EmploymentHistory.Add(EmploymentHistoryMapper.ToEntity(employmentHistory));
            _context.SaveChanges();
        }

        public void UpdateEmploymentHistory(int id, EmploymentHistoryModel employmentHistory)
        {
            _context.EmploymentHistory.Update(EmploymentHistoryMapper.ToEntity(employmentHistory));
            _context.SaveChanges();
        }

        public void DeleteEmploymentHistory(int historyId)
        {
            var entity = _context.EmploymentHistory.Find(historyId);
            if (entity != null)
            {
                _context.EmploymentHistory.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
