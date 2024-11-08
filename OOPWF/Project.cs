using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OOPWF
{
    //dùng trong project
    [Serializable]
    public class Project: Ientity, Task,LISTEMPLOYEEINPROJECT
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private List<EmployeeInProject> listemployees = new List<EmployeeInProject>();
        public List<EmployeeInProject> Listemployees
        {
            get { return listemployees; }
            set { listemployees = value; }
        }
        public void AddEmployee(EmployeeInProject employee)//thêm 
        {
            listemployees.Add(employee);
        }
        public void RemoveEmployee(EmployeeInProject employee)//xóa 
        {
            listemployees.Remove(employee);
        }
    }
}
