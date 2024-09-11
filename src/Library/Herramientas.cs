namespace Library;

public class Herramientas
{
    public static void ValidarNombre(string nombre)
    {
        string caracteresPermitidos = "qQwWeErRtTyYuUiIoOpPsSaAdDFfGgHhJjKkLlÑñZzXxCcVvBbNnMm ";
        foreach (char caracter in nombre.TrimStart())
        {
            if (!caracteresPermitidos.Contains(caracter))
            {
                throw new ArgumentException("Nombre inválido");
            }
        }

        if (nombre.TrimStart() == "")
        {
            throw new ArgumentException("Nombre inválido");
        }
    }
}