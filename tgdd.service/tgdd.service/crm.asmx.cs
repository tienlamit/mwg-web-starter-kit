using System;
using System.Linq;
using System.Web.Services;
using tgdd.service.BO;

namespace tgdd.service
{
    /// <summary>
    /// Summary description for crm
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class crm : System.Web.Services.WebService
    {
        [WebMethod]
        public OrderResultBo CreateOrder(OrderBo order)
        {
            if (order == null || string.IsNullOrEmpty(order.Name) || string.IsNullOrEmpty(order.Phone) ||
                order.ProductList == null || !order.ProductList.Any())
                return new OrderResultBo("Thông tin dữ liệu không hợp lệ");

            var result = new OrderResultBo()
            {
                IsError = false,
                OrderId = DateTime.Now.Ticks
            };

            return result;
        }
    }
}
