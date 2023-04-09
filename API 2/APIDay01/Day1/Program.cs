



using Microsoft.AspNetCore.Builder;

internal class Program
{
    static int countafter = 0;
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();

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

        app.Use(async (context, next) =>
        {

            await next(context);
            countafter++;
            Console.WriteLine("Counter After All Reuests :" + countafter);
            // code after calling
        });



        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}