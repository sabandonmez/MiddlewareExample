namespace MiddlewareExample.Middlewares
{
    public class HelloMiddleware
    {
       RequestDelegate _next;
       public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpcontext)
        {
            //Custom Operasyonlar.

            Console.WriteLine("Selamuuuun Aleyküüüüüüm");
            await _next.Invoke(httpcontext);
            Console.WriteLine("Aleykümm Selaaaaaammm");
        }


    }
}
