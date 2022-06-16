using System;

namespace AppServices.DTOs
{
    public class DetailDTO : BaseDetailDTO
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public FullEmployeeDTO Employee { get; set; }

    }
}
