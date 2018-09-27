using System.Collections.Generic;

namespace tgdd.service.BO
{
    public class ProductBo
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public CategoryBo Category { get; set; }
        public int ManufactureId { get; set; }
        public ManufactureBo Manufacture { get; set; }
        public string ManufactureName { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public decimal Price { get; set; }
        public decimal HisPrice { get; set; }
        public List<string> Promotions{ get;set; }
    }
}