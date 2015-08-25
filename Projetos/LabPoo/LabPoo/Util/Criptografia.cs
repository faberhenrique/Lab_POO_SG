using System;
using System.Text.RegularExpressions;

public class Criptografia
{

    public String CifraCesar(String senha, int key)
    {
        //Removendo Espaços utilizando expressão regular
        String senhaAjustada = Regex.Replace(senha, @"\s", "");
        //Considerando apenas o limite do alfabeto
        int novaKey = key % 26;

        char[] buffer = senhaAjustada.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            // recuperando a Letra.
            char letter = buffer[i];
            // Fazendo o Shift
            letter = (char)(letter + novaKey);
            // Subtrair 26 caso seja maior que Z.
            // Aumentar 26 caso letra seja menor que a.
            if (letter > 'z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'a')
            {
                letter = (char)(letter + 26);
            }
            // Store.
            buffer[i] = letter;
        }
        return new string(buffer);
    }
}
