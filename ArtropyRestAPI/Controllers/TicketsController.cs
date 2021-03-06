using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArtropyRestApi;
using ArtropyRestApi.Model;

namespace ArtropyRestApi.Controllers
{
  [Produces("application/json")]
  [Route("api/Tickets")]
  public class TicketsController : Controller
  {
    private readonly ApiDbContext _context;

    public TicketsController(ApiDbContext context)
    {
      _context = context;
    }


    // GET: api/Accounts
    [HttpGet]
    public IEnumerable<Ticket> GetAccount()
    {
      return _context.Ticket;
    }

    // GET: api/Accounts/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAccount([FromRoute] int id)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      var account = await _context.Account.SingleOrDefaultAsync(m => m.id == id);

      if (account == null)
      {
        return NotFound();
      }

      return Ok(account);
    }

    // PUT: api/Accounts/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAccount([FromRoute] int id, [FromBody] Account account)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      if (id != account.id)
      {
        return BadRequest();
      }

      _context.Entry(account).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AccountExists(id))
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

    // POST: api/Accounts
    [HttpPost]
    public async Task<IActionResult> PostAccount([FromBody] Account account)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      _context.Account.Add(account);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetAccount", new { id = account.id }, account);
    }

    // DELETE: api/Accounts/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAccount([FromRoute] int id)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      var account = await _context.Account.SingleOrDefaultAsync(m => m.id == id);
      if (account == null)
      {
        return NotFound();
      }

      _context.Account.Remove(account);
      await _context.SaveChangesAsync();

      return Ok(account);
    }

    private bool AccountExists(int id)
    {
      return _context.Account.Any(e => e.id == id);
    }

    public void subscribe()
    {

    }
    public void unsubscribe()
    {

    }
    public void viewDigitAsset()
    {

    }
    public void uploadDigitalAsset()
    {

    }
    public void deleteDigitalAsset()
    {

    }
    public void logOut()
    {

    }
    public void login()
    {

    }
    public void followers() { }
    public void following() { }
    public void favoriteDigitalAsset()
    {

    }
    public void favorites()
    {

    }
    public void donate() { }
    public void history()
    {

    }
    public void getShoppingCart()
    {

    }
    public void purchaseShoppingCart()
    {

    }
    public void updateAccount()
    {

    }
    public void notifications()
    {

    }
    public void homeFeed()
    {

    }
    public IEnumerable<string> accountInfo()
    {
      return new string[] { "value1", "value2" };
    }
    public void submitTicket()
    {

    }
    public void ticketDetails()
    {

    }
    public void myTickets()
    {

    }

  }
}
