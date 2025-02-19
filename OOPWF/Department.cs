﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OOPWF
{
    //dùng trong department
    [Serializable]
    public class Department : Ientity, LISTEMPLOYEE
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
        private Manager manager;
        public Manager Manager
        {
            get { return manager; }
            set {  manager = value; }
        }
        private List<EMPLOYEEUNDER> listemployees = new List<EMPLOYEEUNDER>();
        public List<EMPLOYEEUNDER> Listemployees
        {
            get { return listemployees; }
            set { listemployees = value; }
        }
        public void AddEmployee(EMPLOYEEUNDER employee)//thêm 
        {
            listemployees.Add(employee);
        }
        public void RemoveEmployee(EMPLOYEEUNDER employee)//xóa 
        {
            listemployees.Remove(employee);
        }
    }
}
