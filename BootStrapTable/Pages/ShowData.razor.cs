using System.ComponentModel.DataAnnotations;

namespace BootStrapTable.Pages
{
    public partial class ShowData
    {
        class Employee
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "Name is required")]
            [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only alphanumeric characters allowed")]
            [MaxLength(15, ErrorMessage = "Max 15 characters allowed")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invalid email format")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Age is required")]
            [Range(18, 99, ErrorMessage = "Age must be between 18 and 99")]
            public int Age { get; set; }

            [Required(ErrorMessage = "Department is required")]
            public string Department { get; set; }
            public bool isDeleted { get; set; }=false;
        }

        List<Employee> employees = new();
        Employee? editEmployee;
        Employee newEmployee = new Employee();
        private void DeleteRow(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if(emp != null)
            {
                emp.isDeleted = true;
            }
        }
        private void AddEmployee()
        {
                int nextId = employees.Any() ? employees.Max(e => e.Id) + 1 : 1;
                employees.Add(new Employee
                {
                    Id = nextId,
                    Name = newEmployee.Name,
                    Email = newEmployee.Email,
                    Age=newEmployee.Age,
                    Department = newEmployee.Department,
                    isDeleted = false
                });

                newEmployee = new Employee(); 
        }
        private void StartEdit(Employee emp)
        {
            editEmployee = new Employee
            {
                Id = emp.Id,
                Name = emp.Name,
                Email = emp.Email,
                Age=emp.Age,
                Department = emp.Department
            };
        }

        private void SaveEdit()
        {
            var original = employees.FirstOrDefault(e => e.Id == editEmployee.Id);
            if (original != null)
            {
                original.Name = editEmployee.Name;
                original.Email = editEmployee.Email;
                original.Age = editEmployee.Age;
                original.Department = editEmployee.Department;
            }
            editEmployee = null;
        }
        private void CancelEdit()
        {
            editEmployee = null;
        }
    }

}
