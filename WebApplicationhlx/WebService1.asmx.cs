using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System;

namespace WebApplicationhlx
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        ApplicationDbContext db = new ApplicationDbContext();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /*创建商品
        *设定商品各属性值
        *生成购物清单增补商品
        *删除商品
        *浏览/查询购物清单列表
        */
        [WebMethod]
        public void CreateProduct(string name, string description, double price)
        {
            Product product = new Product() { Id = Guid.NewGuid().ToString(), Name = name, Description = description, Price = price };
            db.Products.Add(product);
            db.SaveChanges();
        }

        [WebMethod]
        public void Edit(string id, string name, string description, double price)
        {
            Product product = db.Products.Find(id);
            product.Name = name;
            product.Description = description;
            product.Price = price;
            db.SaveChanges();
        }

        [WebMethod]
        public int DeleteProduct(string id)
        {
            int val = 1;
            if(db.Products.Find(id) != null)
            {
                val = 0;
                db.Products.Remove(db.Products.Find(id));
                db.SaveChanges();
            }
            else
            {
                val = 1;
            }
            return val;
        }

        [WebMethod]
        public ShopRecord[] GetShopRecords()
        {
            return db.ShopRecords.ToArray();
        }

        [WebMethod]
        public Product[] ShowAllProducts()
        {
            return db.Products.ToArray();
        }

        [WebMethod]
        public Product Find(string id)
        {
            return db.Products.Find(id);
        }

    }
}
