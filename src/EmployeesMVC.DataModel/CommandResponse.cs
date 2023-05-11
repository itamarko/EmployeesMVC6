namespace EmployeesMVC.DataModel
{
    public class CommandResponse
    {
        public string Status { get; set; }
        public string Message { get; set; } 
    }

    public class CommandResponse<T> : CommandResponse
    {
        public T Data { get; set; }
    }
}