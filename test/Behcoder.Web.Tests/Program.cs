using Microsoft.AspNetCore.Builder;
using Behcoder;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<BehcoderWebTestModule>();

public partial class Program
{
}
