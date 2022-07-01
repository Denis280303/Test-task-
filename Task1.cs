using System;


namespace task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string text = Console.ReadLine();
            Console.Write("Enter num: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(encrypt(text,n));
            //Console.WriteLine(decrypt(text, n));
        }
        static string encrypt(string text, int n)
        {
            if (string.IsNullOrEmpty(text) || n <= 0)
            {
                return text;
            }
            string encrypted_text = "";
            for (int j = 0; j < n; j++)
            {
                for (int i = 1; i < text.Length; i += 2)
                {
                    encrypted_text += text[i];
                }
                for (int i = 0; i < text.Length; i += 2)
                {
                    encrypted_text += text[i];
                }
                text = encrypted_text;
                encrypted_text = "";
            }
            return text;
        }
//----------Variant 2 (encrypt) -----------
        //static string encrypt(string text, int n)
        //{
        //    if (string.IsNullOrEmpty(text) || n <= 0)
        //    {
        //        return text;
        //    }
        //    string pair = "";
        //    string npair = "";
        //    for (int j = 0; j < n; j++)
        //    {
        //        for (int i = 1; i < text.Length; i += 2)
        //        {
        //            pair += text[i];
        //        }
        //        for (int i = 0; i < text.Length; i += 2)
        //        {
        //            npair += text[i];
        //        }
        //        text = String.Concat(pair, npair);
        //        pair = "";
        //        npair = "";

        //    }
        //    return text;
        //}
        static string decrypt(string encrypted_text, int n)
        {
            if (string.IsNullOrEmpty(encrypted_text) || n <= 0)
            {
                return encrypted_text;
            }
            string text = "";
            for (int j = 0; j < n; j++)
            {
                int av = (encrypted_text.Length) / 2;
                int p = 0;
                for (int i = av; i <encrypted_text.Length; i++)
                {
                    text += encrypted_text[i];
                    if (p< (encrypted_text.Length / 2))
                    {
                        text += encrypted_text[p];
                        p++;
                    }
                }
                encrypted_text = text;
                text = "";
            }return encrypted_text;
        }
    }
}
