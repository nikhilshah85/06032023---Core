namespace DI_Demo.Models
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public string empDesignation { get; set; }
        public bool empIsPermenant { get; set; }

        static List<Employee> eList = new List<Employee>()
        {
            new Employee(){ empName ="Nikhil", empNo=101, empDesignation="Developer", empIsPermenant=true, empSalary=2000 },
            new Employee(){ empName ="Manish", empNo=102, empDesignation="Developer", empIsPermenant=true, empSalary=2000 },
            new Employee(){ empName ="Kirthi", empNo=103, empDesignation="Developer", empIsPermenant=true, empSalary=2000 },
            new Employee(){ empName ="Raman", empNo=104, empDesignation="Developer", empIsPermenant=true, empSalary=2000 },
            new Employee(){ empName ="Pari", empNo=105, empDesignation="Developer", empIsPermenant=true, empSalary=2000 },
        };

        public List<Employee> GetAllEmployees()
        {
            return eList;
        }
    }
}
