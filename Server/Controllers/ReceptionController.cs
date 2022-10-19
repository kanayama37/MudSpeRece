using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MudSpeRece.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionController : ControllerBase
    {
        private readonly DataContext _context;

        public ReceptionController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Reception>>> GetReceptions()
        {
            var receptions = await _context.Receptions.ToListAsync();
            return Ok(receptions);
        }
        //　データ作成処理
        [HttpPost]
        public async Task<ActionResult<List<Reception>>> CreateReception(Reception reception)
        {
            _context.Receptions.Add(reception);
            await _context.SaveChangesAsync();

            return Ok(await GetDbReceptions());
        }

        // 受付データベースの読み込み
        private async Task<List<Reception>> GetDbReceptions()
        {
            return await _context.Receptions.ToListAsync();
        }
    }
}
