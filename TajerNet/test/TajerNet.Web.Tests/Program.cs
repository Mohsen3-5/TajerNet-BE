using Microsoft.AspNetCore.Builder;
using TajerNet;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("TajerNet.Web.csproj"); 
await builder.RunAbpModuleAsync<TajerNetWebTestModule>(applicationName: "TajerNet.Web");

public partial class Program
{
}
