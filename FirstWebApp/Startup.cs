using Microsoft.AspNetCore.Builder;

class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseStaticFiles();
    }
    
}