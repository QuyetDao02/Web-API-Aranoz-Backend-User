using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using BLL.Interface;

namespace BTL_NguoiDung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewProductController : ControllerBase
    {
        IViewProductBusiness db;
        public ViewProductController(IViewProductBusiness db)
        {
            this.db = db;
        }

        [Route("Get-all-product")]
        [HttpGet]
        public List<DoNoiThat> GetAllData()
        {
            return db.GetAllData();
        }

        [Route("New-Product")]
        [HttpGet]
        public List<DoNoiThat> DoNoiThatMoi(int sl)
        {
            return db.DoNoiThatMoi(sl);
        }

        [Route("selling-product")]
        [HttpGet]
        public List<DoNoiThat> DoNoiThatBanChay(int sl)
        {
            return db.DoNoiThatBanChay(sl);
        }
        [Route("Get-Product-Id/{id}")]
        [HttpGet]
        public DoNoiThat GetProductId(int id)
        {
            return db.GetProductId(id);
        }
        [Route("Get-product-categoryid")]
        [HttpGet]
        public List<DoNoiThat> Get_product_categoryid(int id)
        {
            return db.Get_product_categoryid(id);
        }
    }
}
