using Application.Services.Deliveries;
using Application.Services.Order;
using Application.Services.Payments;
using Application.Services.Payments.Factory;
using Core.Contracts.Payments;
using Core.Contracts.Payments.Factory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region IoC

builder.Services.AddScoped<CreditCardService>();
builder.Services.AddScoped<PaymentSlipService>();

builder.Services.AddScoped<InternationalDeliveryService>();
builder.Services.AddScoped<NationalDeliveryService>();

builder.Services.AddScoped<IPaymentServiceFactory, PaymentServiceFactory>();

builder.Services.AddScoped<InternationalOrderAbstractFactory>();
builder.Services.AddScoped<NationalOrderAbstractFactory>();

#endregion

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
