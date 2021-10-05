using AutoMapper;
using Domain;
using Service.DTOs;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public EmployeeService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<EmployeeDTO> GetAllEmployees()
        {
            var employees = _context.Employees.ToList();

            return _mapper.Map<List<EmployeeDTO>>(employees);
        }

        public EmployeeDTO GetEmployeeById(int id)
        {
            var employee = _context.Employees.FirstOrDefault(m => m.Id == id);
            return _mapper.Map<EmployeeDTO>(employee);
        }
    }
}
