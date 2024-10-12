namespace Company
{
    /// <summary>
    /// Represents an employee of the organization
    /// </summary>
    public class GoogleEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }

        public Department dept { get; set; }
    }
}