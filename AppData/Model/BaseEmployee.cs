namespace AppData.Model
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsRemove { get; set; }
    }
}
