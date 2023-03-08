namespace MVCEmployeeManagement.Models
{
    public class EmployeeModel
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        static List<EmployeeModel> eList = new List<EmployeeModel>()
        {
            new EmployeeModel(){ empNo=101, empName="Sahil", empDesignation="Sales", empIsPermenant=true, empSalary=6000 },
            new EmployeeModel(){ empNo=102, empName="Karan", empDesignation="HR", empIsPermenant=true, empSalary=16000 },
            new EmployeeModel(){ empNo=103, empName="Priya", empDesignation="Sales", empIsPermenant=false, empSalary=12000 },
            new EmployeeModel(){ empNo=104, empName="Riya", empDesignation="HR", empIsPermenant=true, empSalary=19000 },
            new EmployeeModel(){ empNo=105, empName="Anand", empDesignation="Sales", empIsPermenant=false, empSalary=22000 }
        };

        public List<EmployeeModel> GetAllEmployees()
        {
            return eList;
        }

        public EmployeeModel SearchById(int id)
        {
            var emp = eList.Find(e => e.empNo == id);

            if (emp != null)
            {
                return emp;
            }
            throw new Exception("Employee Not Found");
        }


        public List<EmployeeModel> FilterByDesignation(string designation)
        {
            var emp = eList.FindAll(em => em.empDesignation == designation);
            return emp;
        }

        public string AddEmployee(EmployeeModel newEmp)
        {
            eList.Add(newEmp);
            return "Employee Added Successfully";
        }

    }
}




























