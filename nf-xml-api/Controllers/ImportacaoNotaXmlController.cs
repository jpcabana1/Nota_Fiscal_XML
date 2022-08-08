using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nf_xml_api.Models;

namespace nf_xml_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportacaoNotaXmlController : ControllerBase
    {
        private readonly NotaFiscalContext _context;

        public ImportacaoNotaXmlController(NotaFiscalContext context)
        {
            _context = context;
        }

        // GET: api/ImportacaoNotaXml
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportacaoNotaXml>>> GetImportacaoNotaXmls()
        {
          if (_context.ImportacaoNotaXmls == null)
          {
              return NotFound();
          }
            return await _context.ImportacaoNotaXmls.ToListAsync();
        }

        // GET: api/ImportacaoNotaXml/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImportacaoNotaXml>> GetImportacaoNotaXml(long id)
        {
          if (_context.ImportacaoNotaXmls == null)
          {
              return NotFound();
          }
            var importacaoNotaXml = await _context.ImportacaoNotaXmls.FindAsync(id);

            if (importacaoNotaXml == null)
            {
                return NotFound();
            }

            return importacaoNotaXml;
        }

        // PUT: api/ImportacaoNotaXml/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportacaoNotaXml(long id, ImportacaoNotaXml importacaoNotaXml)
        {
            if (id != importacaoNotaXml.IdNota)
            {
                return BadRequest();
            }

            _context.Entry(importacaoNotaXml).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImportacaoNotaXmlExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ImportacaoNotaXml
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ImportacaoNotaXml>> PostImportacaoNotaXml(ImportacaoNotaXml importacaoNotaXml)
        {
          if (_context.ImportacaoNotaXmls == null)
          {
              return Problem("Entity set 'NotaFiscalContext.ImportacaoNotaXmls'  is null.");
          }
            _context.ImportacaoNotaXmls.Add(importacaoNotaXml);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImportacaoNotaXml", new { id = importacaoNotaXml.IdNota }, importacaoNotaXml);
        }

        // DELETE: api/ImportacaoNotaXml/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImportacaoNotaXml(long id)
        {
            if (_context.ImportacaoNotaXmls == null)
            {
                return NotFound();
            }
            var importacaoNotaXml = await _context.ImportacaoNotaXmls.FindAsync(id);
            if (importacaoNotaXml == null)
            {
                return NotFound();
            }

            _context.ImportacaoNotaXmls.Remove(importacaoNotaXml);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ImportacaoNotaXmlExists(long id)
        {
            return (_context.ImportacaoNotaXmls?.Any(e => e.IdNota == id)).GetValueOrDefault();
        }
    }
}
