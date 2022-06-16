using System.Collections.Generic;

namespace AppData.Model
{
    public class Employee : BaseEmployee
    {
        public IEnumerable<Detail> Details { get; set; }
    }
}
