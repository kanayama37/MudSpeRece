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
        public async Task<ActionResult<List<Reception>>> GetReceptions([FromQuery] string? cusName)
        {
            var receptions = await _context.Receptions
                .WhereIf(!string.IsNullOrWhiteSpace(cusName), x => x.CusName.Contains(cusName))
                .ToListAsync();
            return Ok(receptions);
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Reception>>> GetReceptions()
        //{
        //    var receptions = await _context.Receptions.ToListAsync();
        //    return Ok(receptions);
        //}

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



        // データ参照
        [HttpGet("{id}")]
        public async Task<ActionResult<Reception>> GetReception(int id)
        {
            var reception = await _context.Receptions
                .FirstOrDefaultAsync(h => h.Id == id);
            if (reception == null)
            {
                return NotFound("Sorry, no reception here. :/");
            }
            return Ok(reception);
        }

        //　データ更新処理
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Reception>>> UpdateSuperHero(Reception reception, int id)
        {
            var dbReception = await _context.Receptions
                .FirstOrDefaultAsync(sh => sh.Id == id);
            if (dbReception == null)
                return NotFound("Sorry, but no reception for you. :/");

            dbReception.Userid = reception.Userid;
            dbReception.RecDate = reception.RecDate;
            dbReception.RegName = reception.RegName;
            dbReception.RecName = reception.RecName;
            dbReception.CusName = reception.CusName;
            dbReception.Body = reception.Body;
            dbReception.Containa = reception.Containa;
            dbReception.WorkDivisionId = reception.WorkDivisionId;
            dbReception.Checkbox = reception.Checkbox;
            dbReception.Checkbox1 = reception.Checkbox1;
            dbReception.Checkbox2 = reception.Checkbox2;
            dbReception.Checkbox3 = reception.Checkbox3;
            dbReception.CreatedAt = reception.CreatedAt;
            dbReception.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return Ok(await GetDbReceptions());
        }

        //　データ削除処理
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Reception>>> DeleteReception(int id)
        {
            var dbReception = await _context.Receptions
                .FirstOrDefaultAsync(sh => sh.Id == id);
            if (dbReception == null)
                return NotFound("Sorry, but no Reception for you. :/");

            _context.Receptions.Remove(dbReception);
            await _context.SaveChangesAsync();

            return Ok(await GetDbReceptions());
        }

        
    }
}
