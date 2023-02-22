namespace Desafio
{
    public static class Criptografia
    {
        private static readonly Dictionary<char, char> tabelaDeCaracteres = new Dictionary<char, char>
        {
            {'a', 'K'}, {'b', 'C'}, {'c', 'B'}, {'d', 'A'}, {'e', 'L'}, {'f', 'M'}, {'g', 'N'}, {'h', 'O'},
            {'i', 'P'}, {'j', 'Q'}, {'k', 'R'}, {'l', 'S'}, {'m', 'D'}, {'n', 'J'}, {'o', 'E'}, {'p', 'F'},
            {'q', 'G'}, {'r', 'T'}, {'s', 'U'}, {'t', 'H'}, {'u', 'I'}, {'v', 'W'}, {'w', 'V'}, {'x', 'Y'},
            {'y', 'X'}, {'z', 'Z'},
        };

        public static string DescriptarTexto(string textoEncriptado)
        {
            string textoDescriptado = textoEncriptado.ToLower();

            foreach (var (chave, valor) in tabelaDeCaracteres)
            {
                textoDescriptado = textoDescriptado.Replace(valor, chave);
            }

            return textoDescriptado;
        }

        public static string EncriptarTexto(string textoDescriptado)
        {
            string textoEncriptado = textoDescriptado.ToLower();

            foreach (var (chave, valor) in tabelaDeCaracteres)
            {
                textoEncriptado = textoEncriptado.Replace(chave, valor);
            }

            return textoEncriptado;
        }
    }
}
