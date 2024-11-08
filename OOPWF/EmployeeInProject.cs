using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OOPWF
{
    //dùng trong project
    public class EmployeeInProject: EMPLOYEEUNDER, Task
    {
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
    public interface LISTEMPLOYEEINPROJECT
    {

        //List<EMPLOYEEUNDERMANAGER> employees { get; set; }
        void AddEmployee(EmployeeInProject employee);//thêm nhân viên
        void RemoveEmployee(EmployeeInProject employee);//xóa nhân viên
    }
}
