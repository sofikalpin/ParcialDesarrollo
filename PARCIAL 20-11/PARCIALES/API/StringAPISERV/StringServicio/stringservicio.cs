namespace StringServicio
{
    public class stringservicio : IStringServicio
    {
        public int obtenerLongitud(string input)
        {
            return input.Length;

        }
    }
}
