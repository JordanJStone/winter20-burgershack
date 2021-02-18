using System.Collections.Generic;
using System.Data;
using Dapper;
using winter20_burgershack.Models;

namespace winter20_burgershack.Repositories
{
  public class SidesRepository
  {

    public readonly IDbConnection _db;

    public SidesRepository(IDbConnection db)
    {
      _db = db;
    }

    // NOTE dotnet add package dapper - to be able to communicate with db
    public IEnumerable<Side> GetAll()
    {
      string sql = "SELECT * FROM sides;";
      return _db.Query<Side>(sql);
    }

    internal Side GetById(int id)
    {
      string sql = "SELECT * FROM sides WHERE id = @id;";
      return _db.QueryFirstOrDefault<Side>(sql, new { id });
    }

    internal Side Create(Side newSide)
    {
      string sql = @"
    INSERT INTO sides
    (name, price)
    VALUES
    (@Name, @Price);
    SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newSide);
      newSide.Id = id;
      return newSide;
    }

    internal void Delete(Side side)
    {
      string sql = "DELETE FROM sides WHERE id = @Id";
      _db.Execute(sql, side);
    }

    internal Side Edit(Side original)
    {
      string sql = @"
    UPDATE sides
    SET
        name = @Name,
        price = @Price
    WHERE id = @Id;
    SELECT * FROM sides WHERE id = @Id;";
      return _db.QueryFirstOrDefault<Side>(sql, original);
    }

  }
}