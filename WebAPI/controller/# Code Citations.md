# Code Citations

## License: MIT
https://github.com/BlaiseD/LogicBuilder.Samples/tree/f02595c347251d04428c90a91987ba7d161bb921/SPA/Contoso/Contoso.KendoGrid.Api/Program.cs

```
);

   var app = builder.Build();

   // Configure the HTTP request pipeline.
   if (app.Environment.IsDevelopment())
   {
       app.UseDeveloperExceptionPage();
       app.UseSwagger();
       app.UseSwaggerUI(c => c.SwaggerEndpoint("/
```


## License: unknown
https://github.com/Fernando2020/ExemploRelacionamentoEntity/tree/04da1f0aad5f53e1ec19ec4bef79aa0c64cbbb74/src/ExemploRelacionamentoEntity.WebApi/Program.cs

```
, Version = "v1" });
   });

   var app = builder.Build();

   // Configure the HTTP request pipeline.
   if (app.Environment.IsDevelopment())
   {
       app.UseDeveloperExceptionPage();
       app.UseSwagger();
       app.UseSwaggerUI
```


## License: unknown
https://github.com/eehanly/Book-RestAPI/tree/7b3e525743fa004a9c8aa34419d2151b7f49d5d0/Program.cs

```
AddEndpointsApiExplorer();
   builder.Services.AddSwaggerGen(c =>
   {
       c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "WebAPI", Version = "v1" });
   });

   var app = builder.Build(
```


## License: unknown
https://github.com/pipo99/InfinitIMO/tree/95e58dd6711293ddea792d199eb5e86a565f5dc8/PropertyService/Program.cs

```
);

   // Add services to the container.
   builder.Services.AddControllers();
   builder.Services.AddEndpointsApiExplorer();
   builder.Services.AddSwaggerGen(c =>
   {
       c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title =
```


## License: unknown
https://github.com/fridabne/CORE.Users.frida/tree/05eeee23a6f25693705bc70f3ea36d0bb7ea4afd/WebAPI/Program.cs

```
app.UseSwagger();
       app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
   }

   app.UseHttpsRedirection();

   app.UseAuthorization();

   app.MapControllers();

   app
```

