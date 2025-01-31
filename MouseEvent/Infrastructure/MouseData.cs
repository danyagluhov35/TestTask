namespace MouseEvent.Infrastructure
{
    public class MouseData
    {
        public MouseData()
        {
            Id = Guid.NewGuid().ToString();
            DateCreate = DateTime.Now;
        }
        public string Id { get; set; }

        public DateTime DateCreate { get; set; }

        public string MouseDataItem { get; set; }
    }
}
