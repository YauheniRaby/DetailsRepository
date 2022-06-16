using System;

namespace AppData.Model
{
    public class Detail
    {
        public int Id { get; set; }

        public string VendorCode { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? RemoveDate { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
