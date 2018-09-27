
namespace tgdd.service.BO
{
    public class ManufactureBo
    {
        public int Id { get; set; }
        public string ManufactureName { get; set; }
    }

    public enum ManufactureId
    {
        Apple = 1000,
        Samsung = 1001,
        Oppo = 1002,
        Sony = 1003
    }
}