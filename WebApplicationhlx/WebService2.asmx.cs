using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationhlx
{
    /// <summary>
    /// WebService2 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {
        ApplicationDbContext db = new ApplicationDbContext();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        ///浏览商品
        ///生成购物清单购买（减少）商品
        [WebMethod]
        public Product[] GetProductList()
        {
            return db.Products.ToArray();
        }

        [WebMethod]
        public void AddProductToShoppingList(string id)
        {
            Product product = db.Products.Find(id);
            if(db.ShoppingList.Find(id) != null)
            {
                SelectedProduct s = db.ShoppingList.Find(id);
                s.num++;
            } else {
                SelectedProduct sProduct = new SelectedProduct()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    num = 1
                };
                db.ShoppingList.Add(sProduct);
            }
            
            db.SaveChanges();
        }

        [WebMethod]
        public SelectedProduct[] FinishShopping()
        {
            ShopRecord shopRecord = new ShopRecord()
            {
                Id = Guid.NewGuid().ToString(),
                Time = DateTime.Now,
                Sum = db.ShoppingList.Sum(x => x.Price * x.num)
            };
            db.ShopRecords.Add(shopRecord);
            SelectedProduct[] Ans = db.ShoppingList.ToArray();
            db.ShoppingList.RemoveRange(db.ShoppingList);
            db.SaveChanges();
            return Ans;
        }

        [WebMethod]
        public double GetAccount()
        {
            if(db.ShoppingList.Count() == 0)
            {
                return 0.0;
            } else
            {
                return db.ShoppingList.Sum(x => x.Price * x.num);
            }
        }

        [WebMethod]
        public int GetNum()
        {
            return db.ShoppingList.Count();
        }

        [WebMethod]
        public void ClearShoppingList()
        {
            db.ShoppingList.RemoveRange(db.ShoppingList);
            db.SaveChanges();
        }

        [WebMethod]
        public SelectedProduct[] ShowSelectedProducts()
        {
            return db.ShoppingList.ToArray();
        }

        [WebMethod]
        public void RemoveSelected(string id)
        {
            SelectedProduct s = db.ShoppingList.Find(id);
            s.num--;
            if(s.num == 0)
            {
                db.ShoppingList.Remove(db.ShoppingList.Find(id));
            }
            db.SaveChanges();
        }
    }
}
