namespace TestDateFormat;
using System.Text;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        StringBuilder sb = new StringBuilder();

        string [] dateParts;
    
        if (date.Contains("/"))
        {
            dateParts = date.Split("/");
        }
        else
        {
            dateParts = date.Split(" ");
        }

        if (string.IsNullOrEmpty(date))
        {
            throw new ArgumentException("La fecha no puede ser nula o vacía.");
        }

        if (dateParts.Length != 3)
        {
            return "Date is not in the correct format";
        }

        if (dateParts[0].Length == 4)
        {
            sb.Append(dateParts[0]);
            sb.Append('-');
            sb.Append(dateParts[1]);
            sb.Append('-');
            sb.Append(dateParts[2]);
        }
        else
        {
            sb.Append(dateParts[2]);
            sb.Append('-');
            sb.Append(dateParts[1]);
            sb.Append('-');
            sb.Append(dateParts[0]);
        }
        return sb.ToString();
    }
}
