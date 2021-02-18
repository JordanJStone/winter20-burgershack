using System.Collections.Generic;
using burgershack_winter20.Models;

// FAKEDB is no longer needed, but will keep it in this project as a good reference
namespace burgershack_winter20.FakeDB
{
  public static class FAKEDB
  {
    public static List<Burger> Burgers { get; set; } = new List<Burger>();
  }
}