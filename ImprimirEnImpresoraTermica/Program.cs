using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

class ConectorPluginV3
{
    public const string URL_PLUGIN_POR_DEFECTO = "http://localhost:8000";
    public static float TAMANO_IMAGEN_NORMAL = 0;
    public static float TAMANO_IMAGEN_DOBLE_ANCHO = 1;
    public static float TAMANO_IMAGEN_DOBLE_ALTO = 2;
    public static float TAMANO_IMAGEN_DOBLE_ANCHO_Y_ALTO = 3;
    public static float ALINEACION_IZQUIERDA = 0;
    public static float ALINEACION_CENTRO = 1;
    public static float ALINEACION_DERECHA = 2;
    public static float RECUPERACION_QR_BAJA = 0;
    public static float RECUPERACION_QR_MEDIA = 1;
    public static float RECUPERACION_QR_ALTA = 2;
    public static float RECUPERACION_QR_MEJOR = 3;

    public List<OperacionPluginV3> operaciones;
    public string urlPlugin;
    public string serial;

    public ConectorPluginV3(string urlPlugin, string serial)
    {
        this.operaciones = new List<OperacionPluginV3>();
        this.urlPlugin = urlPlugin;
        this.serial = serial;
    }

    public ConectorPluginV3(string urlPlugin)
    {
        this.operaciones = new List<OperacionPluginV3>();
        this.urlPlugin = urlPlugin;
        this.serial = "";
    }

    public ConectorPluginV3()
    {
        this.urlPlugin = URL_PLUGIN_POR_DEFECTO;
        this.operaciones = new List<OperacionPluginV3>();
    }

    private void agregarOperacion(OperacionPluginV3 operacion)
    {
        this.operaciones.Add(operacion);
    }

    public ConectorPluginV3 CargarImagenLocalEImprimir(string ruta, float tamano, float maximoAncho)
    {
        this.agregarOperacion(new OperacionPluginV3("CargarImagenLocalEImprimir", new List<object> { ruta, tamano, maximoAncho }));
        return this;
    }

    public ConectorPluginV3 Corte(float lineas)
    {
        this.agregarOperacion(new OperacionPluginV3("Corte", new List<object> { lineas }));
        return this;
    }

    public ConectorPluginV3 CorteParcial()
    {
        this.agregarOperacion(new OperacionPluginV3("CorteParcial", new List<object>()));
        return this;
    }

    public ConectorPluginV3 DefinirCaracterPersonalizado(string caracterRemplazoComoCadena, string matrizComoCadena)
    {
        this.agregarOperacion(new OperacionPluginV3("DefinirCaracterPersonalizado", new List<object> { caracterRemplazoComoCadena, matrizComoCadena }));
        return this;
    }

    public ConectorPluginV3 DescargarImagenDeInternetEImprimir(string urlImagen, float tamano, float maximoAncho)
    {
        this.agregarOperacion(new OperacionPluginV3("DescargarImagenDeInternetEImprimir", new List<object> { urlImagen, tamano, maximoAncho }));
        return this;
    }

    public ConectorPluginV3 DeshabilitarCaracteresPersonalizados()
    {
        this.agregarOperacion(new OperacionPluginV3("DeshabilitarCaracteresPersonalizados", new List<object>()));
        return this;
    }

    public ConectorPluginV3 DeshabilitarElModoDeCaracteresChinos()
    {
        this.agregarOperacion(new OperacionPluginV3("DeshabilitarElModoDeCaracteresChinos", new List<object>()));
        return this;
    }

    public ConectorPluginV3 EscribirTexto(string texto)
    {
        this.agregarOperacion(new OperacionPluginV3("EscribirTexto", new List<object> { texto }));
        return this;
    }

    public ConectorPluginV3 EstablecerAlineacion(float alineacion)
    {
        this.agregarOperacion(new OperacionPluginV3("EstablecerAlineacion", new List<object> { alineacion }));
        return this;
    }

    public ConectorPluginV3 EstablecerEnfatizado(bool enfatizado)
    {
        this.agregarOperacion(new OperacionPluginV3("EstablecerEnfatizado", new List<object> { enfatizado }));
        return this;
    }
    public ConectorPluginV3 EstablecerFuente(float fuente)
    {
        this.agregarOperacion(new OperacionPluginV3("EstablecerFuente", new List<object> { fuente }));
        return this;
    }

    public ConectorPluginV3 EstablecerImpresionAlReves(bool alReves)
    {
        this.agregarOperacion(new OperacionPluginV3("EstablecerImpresionAlReves", new List<object> { alReves }));
        return this;
    }

    public ConectorPluginV3 EstablecerImpresionBlancoYNegroInversa(bool invertir)
    {
        this.agregarOperacion(new OperacionPluginV3("EstablecerImpresionBlancoYNegroInversa", new List<object> { invertir }));
        return this;
    }

    public ConectorPluginV3 EstablecerRotacionDe90Grados(bool rotar)
    {
        this.agregarOperacion(new OperacionPluginV3("EstablecerRotacionDe90Grados", new List<object> { rotar }));
        return this;
    }

    public ConectorPluginV3 EstablecerSubrayado(bool subrayado)
    {
        this.agregarOperacion(new OperacionPluginV3("EstablecerSubrayado", new List<object> { subrayado }));
        return this;
    }

    public ConectorPluginV3 EstablecerTamanoFuente(float multiplicadorAncho, float multiplicadorAlto)
    {
        this.agregarOperacion(new OperacionPluginV3("EstablecerTamañoFuente", new List<object> { multiplicadorAncho, multiplicadorAlto }));
        return this;
    }

    public ConectorPluginV3 Feed(float lineas)
    {
        this.agregarOperacion(new OperacionPluginV3("Feed", new List<object> { lineas }));
        return this;
    }

    public ConectorPluginV3 HabilitarCaracteresPersonalizados()
    {
        this.agregarOperacion(new OperacionPluginV3("HabilitarCaracteresPersonalizados", new List<object>()));
        return this;
    }

    public ConectorPluginV3 HabilitarElModoDeCaracteresChinos()
    {
        this.agregarOperacion(new OperacionPluginV3("HabilitarElModoDeCaracteresChinos", new List<object>()));
        return this;
    }


    public ConectorPluginV3 ImprimirCodigoDeBarrasCodabar(string contenido, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasCodabar", new List<object>() { contenido, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasCode128(string contenido, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasCode128", new List<object>() { contenido, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasCode39(string contenido, bool incluirSumaDeVerificacion, bool modoAsciiCompleto, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasCode39", new List<object>() { contenido, incluirSumaDeVerificacion, modoAsciiCompleto, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasCode93(string contenido, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasCode93", new List<object>() { contenido, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasEan(string contenido, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasEan", new List<object>() { contenido, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasEan8(string contenido, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasEan8", new List<object>() { contenido, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasPdf417(string contenido, float nivelSeguridad, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasPdf417", new List<object>() { contenido, nivelSeguridad, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasTwoOfFiveITF(string contenido, bool intercalado, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasTwoOfFiveITF", new List<object>() { contenido, intercalado, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasUpcA(string contenido, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasUpcA", new List<object>() { contenido, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoDeBarrasUpcE(string contenido, float alto, float ancho, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoDeBarrasUpcE", new List<object> { contenido, alto, ancho, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirCodigoQr(string contenido, float anchoMaximo, float nivelRecuperacion, float tamanoImagen)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirCodigoQr", new List<object> { contenido, anchoMaximo, nivelRecuperacion, tamanoImagen }));
        return this;
    }

    public ConectorPluginV3 ImprimirImagenEnBase64(string imagenCodificadaEnBase64, float tamano, float maximoAncho)
    {
        this.agregarOperacion(new OperacionPluginV3("ImprimirImagenEnBase64", new List<object> { imagenCodificadaEnBase64, tamano, maximoAncho }));
        return this;
    }

    public ConectorPluginV3 Iniciar()
    {
        this.agregarOperacion(new OperacionPluginV3("Iniciar", new List<object>()));
        return this;
    }

    public ConectorPluginV3 Pulso(float pin, float tiempoEncendido, float tiempoApagado)
    {
        this.agregarOperacion(new OperacionPluginV3("Pulso", new List<object> { pin, tiempoEncendido, tiempoApagado }));
        return this;
    }

    public ConectorPluginV3 TextoSegunPaginaDeCodigos(float numeroPagina, string pagina, string texto)
    {
        this.agregarOperacion(new OperacionPluginV3("TextoSegunPaginaDeCodigos", new List<object> { numeroPagina, pagina, texto }));
        return this;
    }

    public async Task<bool> imprimirEn(string nombreImpresora)
    {
        ImpresionConNombrePluginV3 impresion = new ImpresionConNombrePluginV3(this.operaciones, nombreImpresora, this.serial);
        var serializado = JsonSerializer.Serialize(impresion);
        try
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(serializado, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(this.urlPlugin + "/imprimir", content);
                string responseString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<bool>(responseString);
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("Error haciendo petición al plugin. ¿El plugin se está ejecutando y ha comprobado el puerto? el error es: " + e.ToString());

            return false;
        }
    }
    public static async Task<List<string>> obtenerImpresoras(string url = ConectorPluginV3.URL_PLUGIN_POR_DEFECTO)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(url + "/impresoras");
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> impresoras = JsonSerializer.Deserialize<List<string>>(responseBody);
                return impresoras;

            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("Error haciendo petición al plugin. ¿El plugin se está ejecutando y ha comprobado el puerto? el error es: " + e.ToString());

            return new List<string> { };
        }

    }

}

class ImpresionConNombrePluginV3
{
    public List<OperacionPluginV3> operaciones { get; set; }
    public string nombreImpresora { get; set; }
    public string serial { get; set; }

    public ImpresionConNombrePluginV3(List<OperacionPluginV3> operaciones, string nombreImpresora, string serial)
    {
        this.operaciones = operaciones;
        this.nombreImpresora = nombreImpresora;
        this.serial = serial;
    }
}


class OperacionPluginV3
{
    public string nombre { get; set; }
    public List<object> argumentos { get; set; }

    public OperacionPluginV3(string nombre, List<object> argumentos)
    {
        this.nombre = nombre;
        this.argumentos = argumentos;
    }
}


class Program
{
    static async Task Main(string[] args)
    {

        var impresoras = await ConectorPluginV3.obtenerImpresoras();
        foreach (var impresora in impresoras)
        {
            Console.WriteLine($"Tenemos una impresora y es: '{impresora}'");
        }


        /* El nombre de tu impresora instalada como genérica y con un nombre 
         * amigable como se indica en: 
         * https://parzibyte.me/blog/2017/12/11/instalar-impresora-termica-generica/
         */
        var nombreImpresora = "PT210";
        /* Si cuentas con un serial o licencia indícalo aquí. NO ES OBLIGATORIO, pero dejo el ejemplo completo
         * Más información del serial en: 
         * https://parzibyte.me/blog/2022/10/02/contratar-licencia-para-plugin-impresora-termica-v3/
        */
        var serial = "";
        var conector = new ConectorPluginV3(ConectorPluginV3.URL_PLUGIN_POR_DEFECTO, serial);
        conector
        .Iniciar()
        .EstablecerAlineacion(ConectorPluginV3.ALINEACION_CENTRO)
        .EscribirTexto("Estoy en el centro\n")
        .EstablecerAlineacion(ConectorPluginV3.ALINEACION_DERECHA)
        .EscribirTexto("Estoy a la derecha\n")
        .EstablecerAlineacion(ConectorPluginV3.ALINEACION_IZQUIERDA)
        .EscribirTexto("Estoy a la izquierda\n")
        .Feed(2)
        .EstablecerAlineacion(ConectorPluginV3.ALINEACION_CENTRO)
        .ImprimirCodigoQr("Soy un QR impreso desde C# usando el plugin de Parzibyte!", 200, ConectorPluginV3.RECUPERACION_QR_ALTA, ConectorPluginV3.TAMANO_IMAGEN_NORMAL)
        .Iniciar() // En mi impresora es necesario volver a iniciar después de imprimir una imagen
        .EscribirTexto("¿Esto soporta tildes? áéíóú")
        .Feed(1)
        // Recuerda que es posible que la imagen no esté en línea en el futuro. Simplemente coloca otra URL válida en caso de que falle
        .DescargarImagenDeInternetEImprimir(
            "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/d10b9ade-6ca1-4f15-90a6-3825345f5c0b/ddjud3k-ca70e9ff-f5b7-4d09-8232-bd8569a214b5.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcL2QxMGI5YWRlLTZjYTEtNGYxNS05MGE2LTM4MjUzNDVmNWMwYlwvZGRqdWQzay1jYTcwZTlmZi1mNWI3LTRkMDktODIzMi1iZDg1NjlhMjE0YjUucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.jRbiKH4w9GHxuYnj3yM9e4_xcoMYBoJjCjGStLGjh4o",
            ConectorPluginV3.TAMANO_IMAGEN_NORMAL,
            200
            )
        .Iniciar() // En mi impresora es necesario volver a iniciar después de imprimir una imagen
        .Corte(1)
        .CorteParcial()
        .Pulso(48, 60, 120); // Cajón
        var impresoCorrectamente = await conector.imprimirEn(nombreImpresora);
        Console.WriteLine(impresoCorrectamente);
    }
}



