using Blazor.StorageAPITest;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using TG.Blazor.IndexedDB;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddMudServices();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddIndexedDB(dbStore =>
{
    dbStore.DbName = "TheFactory"; //example name
    dbStore.Version = 1;

    dbStore.Stores.Add(new StoreSchema
    {
        Name = "Employees",
        PrimaryKey = new IndexSpec { Name = "id", KeyPath = "id", Auto = true },
        Indexes = new List<IndexSpec>
                    {
                        new IndexSpec{Name="firstName", KeyPath = "firstName", Auto=false},
                        new IndexSpec{Name="lastName", KeyPath = "lastName", Auto=false},
                        new IndexSpec{Name="img", KeyPath = "img", Auto=false},

                    }
    });
    dbStore.Stores.Add(new StoreSchema
    {
        Name = "Outbox",
        PrimaryKey = new IndexSpec { Auto = true }
    });
});

await builder.Build().RunAsync();
