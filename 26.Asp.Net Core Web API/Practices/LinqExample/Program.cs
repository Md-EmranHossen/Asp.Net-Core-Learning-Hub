using LinqExample;

List<Employee> employees = new List<Employee>()
{
   new Employee
   {
       EmpName = "Emran Hossen",
       EmpID = 1,
       City = "Dhaka",
       Job = "Software Developer"
   },

   new Employee
   {
       EmpName = "Rakib",
       EmpID = 2,
       City = "Khulna",
       Job = "DOctor"
   },
    new Employee
   {
       EmpName = "Shakib",
       EmpID = 3,
       City = "Barishal",
       Job = "Cricketer"
   },
    new Employee
   {
       EmpName = "Zakir",
       EmpID = 4,
       City = "Barishal",
       Job = "Manager"
   },
    new Employee
   {
       EmpName = "Tamim",
       EmpID = 5,
       City = "Magura",
       Job = "Cricketer"
   }
};


var result = employees.Select(emp => new Person()
{
    PersonName = emp.EmpName
});