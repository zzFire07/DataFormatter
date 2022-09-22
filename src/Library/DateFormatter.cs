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

        int FirstDate = 0;
        int SecondDate = 0;
        int ThirdDate = 0;
    
        if (date.Contains("/"))
        {
            dateParts = date.Split("/");
        }
        else
        {
            dateParts = date.Split(" ");
        }

        bool isDate = int.TryParse(dateParts[0], out FirstDate) && int.TryParse(dateParts[1], out SecondDate) && int.TryParse(dateParts[2], out ThirdDate);

        if (string.IsNullOrEmpty(date))
        {
            throw new ArgumentException("La fecha no puede ser nula o vacía.");
        }
        if (dateParts.Length != 3)
        {
            throw new ArgumentException("La fecha no tiene el formato correcto.");
        }
        if (!isDate)
        {
            throw new ArgumentException("La fecha no tiene el formato correcto.");
        }
        

        if (dateParts[0].Length == 4 && SecondDate <= 12 && ThirdDate <= 31)
        {
            sb.Append(dateParts[0]);
            sb.Append("-");
            sb.Append(dateParts[1]);
            sb.Append("-");
            sb.Append(dateParts[2]);
        }
        else if (dateParts[2].Length == 4 && SecondDate <= 12 && FirstDate <= 31)
        {
            sb.Append(dateParts[2]);
            sb.Append("-");
            sb.Append(dateParts[1]);
            sb.Append("-");
            sb.Append(dateParts[0]);
        }
        else
        {
            throw new ArgumentException("La fecha no tiene el formato correcto.");
        }
        return sb.ToString();
    }
}
