//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using LudoParty.Management.Data;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using LudoParty.Server.Models;
//using Swashbuckle.AspNetCore.Annotations;

//namespace LudoParty.Server.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class SettingsController : ControllerBase
//    {
//        private readonly LudoPartyServerContext _context;

//        public SettingsController(LudoPartyServerContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Settings
//        [HttpGet]
//        [SwaggerResponse(200, "")]
//        public async Task<ActionResult<IEnumerable<SettingsModel>>> GetSettingsModel()
//        {
//            return await _context.SettingsModel.ToListAsync();
//        }

//        // GET: api/Settings/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<SettingsModel>> GetSettingsModel(SettingCategory id)
//        {
//            var settingsModel = await _context.SettingsModel.FindAsync(id);

//            if (settingsModel == null)
//            {
//                return NotFound();
//            }

//            return settingsModel;
//        }

//        // PUT: api/Settings/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutSettingsModel(SettingCategory id, SettingsModel settingsModel)
//        {
//            if (id != settingsModel.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(settingsModel).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!SettingsModelExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Settings
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPost]
//        public async Task<ActionResult<SettingsModel>> PostSettingsModel(SettingsModel settingsModel)
//        {
//            _context.SettingsModel.Add(settingsModel);
//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateException)
//            {
//                if (SettingsModelExists(settingsModel.Id))
//                {
//                    return Conflict();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return CreatedAtAction("GetSettingsModel", new { id = settingsModel.Id }, settingsModel);
//        }

//        // DELETE: api/Settings/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<SettingsModel>> DeleteSettingsModel(SettingCategory id)
//        {
//            var settingsModel = await _context.SettingsModel.FindAsync(id);
//            if (settingsModel == null)
//            {
//                return NotFound();
//            }

//            _context.SettingsModel.Remove(settingsModel);
//            await _context.SaveChangesAsync();

//            return settingsModel;
//        }

//        private bool SettingsModelExists(SettingCategory id)
//        {
//            return _context.SettingsModel.Any(e => e.Id == id);
//        }
//    }
//}
