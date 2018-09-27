using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using tgdd.service.BO;
using tgdd.service.DAO;

namespace tgdd.service
{
    /// <summary>
    /// Summary description for product
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class product : System.Web.Services.WebService {
        [WebMethod]
        public List<ProductBo> Search(string keyword, int pageIndex, int pageSize)
        {
            var allProduct = ProductDao.Instance().GetAllProduct();
            if (allProduct == null || !allProduct.Any())
                return null;

            if (!string.IsNullOrEmpty(keyword))
                allProduct = allProduct.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).ToList();
            
            if (allProduct.Count > pageSize)
            {
                if (pageIndex == 0)
                    allProduct = allProduct.Take(pageSize).ToList();
                else
                {
                    allProduct = allProduct.Skip(pageIndex * pageSize).Take(pageSize).ToList();
                }
            }

            return allProduct;
        }

        [WebMethod]
        public List<ProductBo> GetProduct(int categoryId, int manufactureId, bool hasPromo, int pageIndex, int pageSize)
        {
            var allProduct = ProductDao.Instance().GetAllProduct();
            if (allProduct == null || !allProduct.Any())
                return null;
            
            if (categoryId > 0)
                allProduct = allProduct.Where(p => p.CategoryId == categoryId).ToList();

            if (manufactureId > 0)
                allProduct = allProduct.Where(p => p.ManufactureId == manufactureId).ToList();

            if (hasPromo)
                allProduct = allProduct.Where(p => p.HisPrice > 0 || p.Promotions.Any()).ToList();

            if (allProduct.Count > pageSize)
            {
                if (pageIndex == 0)
                    allProduct = allProduct.Take(pageSize).ToList();
                else
                {
                    allProduct = allProduct.Skip(pageIndex * pageSize).Take(pageSize).ToList();
                }
            }

            return allProduct;
        }

        [WebMethod]
        public ProductBo Detail(int id)
        {
            var allProduct = ProductDao.Instance().GetAllProduct();
            if (allProduct == null)
                return null;

            return allProduct.FirstOrDefault(p => p.Id == id);
        }

        [WebMethod]
        public List<CategoryBo> GetAllCategory()
        {
            var ret = new List<CategoryBo>();

            ret.Add(new CategoryBo()
            {
                Id = (int)CategoryId.Mobile,
                CategoryName = "Điện thoại di động"
            });

            ret.Add(new CategoryBo()
            {
                Id = (int)CategoryId.Laptop,
                CategoryName = "Laptop"
            });

            ret.Add(new CategoryBo()
            {
                Id = (int)CategoryId.Tablet,
                CategoryName = "Tablet"
            });

            ret.Add(new CategoryBo()
            {
                Id = (int)CategoryId.Accessories,
                CategoryName = "Phụ kiện"
            });

            return ret;
        }

        [WebMethod]
        public List<ManufactureBo> GetAllManufacture()
        {
            var ret = new List<ManufactureBo>();

            ret.Add(new ManufactureBo()
            {
                Id = (int)ManufactureId.Apple,
                ManufactureName = "Apple"
            });

            ret.Add(new ManufactureBo()
            {
                Id = (int)ManufactureId.Samsung,
                ManufactureName = "Samsung"
            });

            ret.Add(new ManufactureBo()
            {
                Id = (int)ManufactureId.Oppo,
                ManufactureName = "Oppo"
            });

            ret.Add(new ManufactureBo()
            {
                Id = (int)ManufactureId.Sony,
                ManufactureName = "Sony"
            });

            return ret;
        }
    }
}
