var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Página principal
app.MapGet("/", () => new
{
    mensaje = "Servidor de Programacion Avanzada funcionando",
    estado = "OK"
});

// Ejemplo sencillo
app.MapGet("/api/saludo", () => new
{
    mensaje = "Hola desde el servidor .NET",
    fecha = DateTime.Now
});

// Simulación de datos de un vehículo
app.MapGet("/api/vehiculo", () => new
{
    velocidad = 85,
    temperatura = 92.5,
    combustible = 63,
    estado = "Normal"
});

// Ejemplo con parámetro enviado por el cliente
app.MapGet("/api/temperatura/{valor}", (double valor) =>
{
    string estado;

    if (valor > 100)
        estado = "ALERTA: Temperatura elevada";
    else
        estado = "Temperatura normal";

    return new
    {
        temperatura = valor,
        estado = estado
    };
});

app.Run();
