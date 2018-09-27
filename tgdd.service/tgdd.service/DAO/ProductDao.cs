using System.Collections.Generic;
using tgdd.service.BO;

namespace tgdd.service.DAO
{
    public class ProductDao
    {
        private static ProductDao _instance;

        public static ProductDao Instance()
        {
            lock (typeof(ProductDao))
            {
                _instance = new ProductDao();
            }
            return _instance;
        }

        public List<ProductBo> GetAllProduct()
        {
            var id = 1000;
            var lstProduct = new List<ProductBo>();

            #region Iphone

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại iPhone X 256GB Gray",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Apple,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/114111/iphone-x-256gb-h2-400x460-400x460.png",
                Price = 32790000,
                HisPrice = 34790000,
                Promotions = new List<string>() { "Phiếu mua hàng trị giá 1,000.000đ", "Cơ hội trúng 30 xe Wave Alpha khi trả góp Home Credit" }
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại iPhone 6s Plus 32GB",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Apple,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/87846/iphone-6s-plus-32gb-400x450-400x450.png",
                Price = 12990000,
                HisPrice = 13990000,
                Promotions = new List<string>()
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại iPhone 8 Plus 256GB",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Apple,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/114114/iphone-8-plus-256gb2-400x460-1-400x460.png",
                Price = 28790000,
                HisPrice = 0,
                Promotions = new List<string>() { "Phiếu mua hàng trị giá 1,000.000đ", "Cơ hội trúng 30 xe Wave Alpha khi trả góp Home Credit" }
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại iPhone 8 Plus Red 64GB (Đỏ)",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Apple,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/158738/iphone-8-red-1-400x460.png",
                Price = 23990000,
                HisPrice = 0,
                Promotions = new List<string>()
            });

            #endregion

            #region Samsung

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại Samsung Galaxy Note 9",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Samsung,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/154897/samsung-galaxy-note-9-black-400x460-400x460.png",
                Price = 22990000,
                HisPrice = 0,
                Promotions = new List<string>() { "Phiếu mua hàng trị giá 1,000.000đ", "Cơ hội trúng chuyến du lịch Hàn Quốc" }
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại Samsung Galaxy A6 (2018)",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Samsung,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/157031/samsung-galaxy-a6-2018-1-400x460.png",
                Price = 6190000,
                HisPrice = 0,
                Promotions = new List<string>()
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại Samsung Galaxy J7 Pro",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Samsung,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/103404/samsung-galaxy-j7-pro-6-400x460.png",
                Price = 22990000,
                HisPrice = 0,
                Promotions = new List<string>()
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại Samsung Galaxy J7+",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Samsung,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/112970/samsung-galaxy-j7-plus-2-400x460.png",
                Price = 7290000,
                HisPrice = 7490000,
                Promotions = new List<string>()
            });

            #endregion

            #region Oppo

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại OPPO A3s",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Oppo,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/183657/oppo-a3s-red-400x460.png",
                Price = 3690000,
                HisPrice = 0,
                Promotions = new List<string>()
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại OPPO F9",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Oppo,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/182153/oppo-f9-red-2-400x460.png",
                Price = 7690000,
                HisPrice = 7190000,
                Promotions = new List<string>() { "Phiếu mua hàng OPPO trị giá 100.000đ" }
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại OPPO Find X",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Oppo,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/165189/oppo-find-x-2-400x460-400x460.png",
                Price = 20990000,
                HisPrice = 0,
                Promotions = new List<string>() { "Tặng gói bảo hiểm rơi vỡ màn hình trong 1 năm khi mua OPPO Find X", "Cơ hội trúng 30 xe Wave Alpha khi trả góp Home Credit" }
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Điện thoại OPPO F7",
                CategoryId = (int)CategoryId.Mobile,
                ManufactureId = (int)ManufactureId.Oppo,
                Avatar = "https://cdn.tgdd.vn/Products/Images/42/155261/oppo-f7-bac-400x460.png",
                Price = 6690000,
                HisPrice = 0,
                Promotions = new List<string>() { "Phiếu mua hàng OPPO trị giá 300.000đ (áp dụng từ 14/9)" }
            });

            #endregion

            #region Sony



            #endregion

            #region Macbook

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Laptop Apple Macbook Pro Touch MR9Q2SA/A i5 2.3GHz/8GB/256GB (2018)",
                CategoryId = (int)CategoryId.Laptop,
                ManufactureId = (int)ManufactureId.Apple,
                Avatar = "https://cdn.tgdd.vn/Products/Images/44/184384/apple-macbook-pro-touch-mr9q2sa-a-2018-thumb-1-600x600.jpg",
                Price = 44490000,
                HisPrice = 0,
                Promotions = new List<string>() { "Phiếu mua hàng trị giá 1,000.000đ", "Cơ hội trúng 30 xe Wave Alpha khi trả góp Home Credit" }
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Laptop Apple Macbook 12\" MNYK2SA / A Core M 1.2GHz / 8GB / 256GB(2017)",
                CategoryId = (int)CategoryId.Laptop,
                ManufactureId = (int)ManufactureId.Apple,
                Avatar = "https://cdn.tgdd.vn/Products/Images/44/111623/apple-macbook-12-mnyk2sa-a-450x300-450x300.jpg",
                Price = 33990000,
                HisPrice = 0,
                Promotions = new List<string>() { "Phiếu mua hàng trị giá 3 triệu", "Cơ hội trúng 30 xe Wave Alpha khi trả góp Home Credit" }
            });

            #endregion

            #region Ipad

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Máy tính bảng iPad Wifi 128 GB (2018)",
                CategoryId = (int)CategoryId.Tablet,
                ManufactureId = (int)ManufactureId.Apple,
                Avatar = "https://cdn.tgdd.vn/Products/Images/522/163791/ipad-6th-wifi-128-gb-1-400x460.png",
                Price = 11990000,
                HisPrice = 0,
                Promotions = new List<string>() { "Giảm ngay 500.000đ", "Cơ hội trúng 30 xe Wave Alpha khi trả góp Home Credit" }
            });

            lstProduct.Add(new ProductBo()
            {
                Id = id++,
                Name = "Máy tính bảng iPad Pro 10.5 inch Wifi 64GB (2017)",
                CategoryId = (int)CategoryId.Tablet,
                ManufactureId = (int)ManufactureId.Apple,
                Avatar = "https://cdn.tgdd.vn/Products/Images/522/106036/ipad-pro-105-inch-wifi-64gb-2017-400-400x460.png",
                Price = 16990000,
                HisPrice = 17990000,
                Promotions = new List<string>() { "Phiếu mua hàng trị giá 3 triệu", "Cơ hội trúng 30 xe Wave Alpha khi trả góp Home Credit" }
            });

            #endregion

            return lstProduct;
        }
    }
}