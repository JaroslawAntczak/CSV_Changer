using CSV_Changer;
using CSV_Changer.Changer;
using CSV_Changer.Items;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSingleton<IApp, App>();
services.AddSingleton<ICSVReader, CSVReader>();

var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>()!;
app.Run();