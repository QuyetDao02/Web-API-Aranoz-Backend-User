using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTL_NguoiDung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiDoNoiThatController : ControllerBase
    {
        public ILoaiDoNoiThatBusiness db;
        public LoaiDoNoiThatController(ILoaiDoNoiThatBusiness db)
        {
            this.db = db;
        }
        [Route("get-all-category")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var data = db.getalldata();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
