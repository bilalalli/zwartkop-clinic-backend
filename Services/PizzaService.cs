using Server.Models;
using Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Server.Services;

public class PizzaService
{
    private readonly ServerContext _context;
    public PizzaService(ServerContext context)
    {
        _context = context;
    }

    public IEnumerable<Pizza> GetAll()
    {
        return _context.Pizzas.AsNoTracking().ToList();
    }

    public Pizza? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Pizza? Create(Pizza newPizza)
    {
        throw new NotImplementedException();
    }

    public void AddTopping(int PizzaId, int ToppingId)
    {
        throw new NotImplementedException();
    }

    public void UpdateSauce(int PizzaId, int SauceId)
    {
        throw new NotImplementedException();
    }

    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }
}