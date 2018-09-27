namespace tgdd.service.BO
{
    public class CategoryBo
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }

    public enum CategoryId
    {
        Mobile = 1000,
        Laptop = 1001,
        Tablet = 1002,
        Accessories = 1003
    }
}