using System.Collections.Generic;
using winter20_burgershack.Models;
using winter20_burgershack.Repositories;

namespace winter20_burgershack.Services
{
  public class SidesService
  {

    private readonly SidesRepository
    _repo;

    public SidesService(SidesRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Side> Get()
    {
      return _repo.GetAll();
    }

    internal Side Get(int id)
    {
      Side side = _repo.GetById(id);
      if (side == null)
      {
        throw new System.Exception("invalid Id");
      }
      return side;
    }

    internal Side Create(Side newSide)
    {
      return _repo.Create(newSide);
    }

    internal Side Edit(Side editSide)
    {
      Side original = Get(editSide.Id);

      original.Name = editSide.Name != null ? editSide.Name : original.Name;

      original.Price = editSide.Price > 0 ? editSide.Price : original.Price;

      return _repo.Edit(original);

    }

    internal Side Delete(int id)
    {
      Side side = Get(id);
      _repo.Delete(side);
      return side;
    }

  }
}