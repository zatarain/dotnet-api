using System.Data.Common;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Entities.Database;
using Microsoft.AspNetCore.Hosting;

namespace HelloWorld.Integration.Tests
{
  public class TestApplicationFactory<TProgram>
    : WebApplicationFactory<TProgram> where TProgram : class
  {
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
      builder.UseEnvironment("Test");
    }
  }
}
