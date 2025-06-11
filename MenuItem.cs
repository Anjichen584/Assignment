namespace SedapMakanChefModule
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:C} - {(IsAvailable ? "Available" : "Unavailable")}";
        }
    }
}
