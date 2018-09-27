
using System;
using System.Collections.Generic;

namespace tgdd.service.BO
{
    [Serializable]
    public class OrderBo
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Province { get; set; }
        public int District { get; set; }
        public string Address { get; set; }
        public decimal Total { get; set; }
        public decimal ShipFee { get; set; }
        public List<OrderDetailBo> ProductList { get; set; }
    }

    [Serializable]
    public class OrderDetailBo
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
    }
}