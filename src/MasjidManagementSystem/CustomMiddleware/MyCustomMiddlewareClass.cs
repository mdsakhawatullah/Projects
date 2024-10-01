namespace MasjidManagementSystem.CustomMiddleware
{
	public class MyCustomMiddlewareClass : IMiddleware
	{
		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{
			await context.Response.WriteAsync("My custom 1 starts FROM 2");
			await next(context);
			await context.Response.WriteAsync("My custom 1 Ends FROM 2");

		}
	}
}
