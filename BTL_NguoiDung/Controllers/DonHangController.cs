using BLL.Interface;
using DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL_NguoiDung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangController : ControllerBase
    {
        public IDonHangBusiness db;
        public DonHangController(IDonHangBusiness db)
        {
            this.db = db;
        }
        [Route("AddToCart")]
        [HttpPost]
        public IActionResult AddCart([FromBody] DonHangBan dh)
        {
            try
            {
                db.AddCart(dh);
                return Ok("Thêm thành công");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
