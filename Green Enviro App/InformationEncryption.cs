using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Green_Enviro_App
{
    class InformationEncryption
        //This class serve as to encrypt all information that need to be protected
    {
        //Encryption and Decryption done through the cryptographic technique DES but here its a tripleDES
        //They requires a key, that needs to be the same for both encryption and decryption 
        //And most importantly needs to be 16 or 24 characters long, not longer, shorter or in between or an exception is
        //Generated preventing encryption, this is because 16 bytes = 128 bits and 24 bytes = 196
        //Which are the bits value only accepted when converting using a Base64

        //Cipher key for 128 bits (changeable depending on devs) !!!! 16 characters
        private const string _128_cipher_key = "JesusYouAreKing!";
        //Cipher  key for 196 bits (changeable depending on devs) !!!! 24 characters
        private const string _196_cipher_key = "ElijahisTheProphetofFire";

        public string Encrypt(string plaintext)
        {
            //Storing the psword or plaintext into a byte array as the content is converted into bytes
            byte[] input_array = UTF8Encoding.UTF8.GetBytes(plaintext);
           
            //Triple DES process where the key is used in order to create encryption
            TripleDESCryptoServiceProvider triple_DES = new TripleDESCryptoServiceProvider
            {
                Key = UTF8Encoding.UTF8.GetBytes(_128_cipher_key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            //Encryption process or cryptograhy process
            ICryptoTransform crypto_encryption = triple_DES.CreateEncryptor();
            byte[] output_array = crypto_encryption.TransformFinalBlock(input_array, 0, input_array.Length);
            triple_DES.Clear();
            string encryption = Convert.ToBase64String(output_array, 0, output_array.Length);
            return encryption;
        }
        //Function that decrypts any encrypted information.
        public string Decrypt(string input)
        {
            //Containing any input information into a array
            byte[] input_array = Convert.FromBase64String(input);
            //Decrypting the array using the Triple DES Cryptography method
            TripleDESCryptoServiceProvider triple_DES = new TripleDESCryptoServiceProvider
            {
                Key = UTF8Encoding.UTF8.GetBytes(_128_cipher_key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            //Decryption process returning the cryptographic content
            ICryptoTransform crypto_decryption = triple_DES.CreateDecryptor();
            byte[] output_array = crypto_decryption.TransformFinalBlock(input_array, 0, input_array.Length);
            triple_DES.Clear();
            string decryption = UTF8Encoding.UTF8.GetString(output_array);
            return decryption;
        }

        /*public void PrintCryptography(string plaintext)
        {
            string ciphertext = Encrypt(plaintext, _128_cipher_key);
            string decrypted_text = Decrypt(ciphertext, _128_cipher_key);
            Console.WriteLine(plaintext);
            Console.WriteLine("");
            Console.WriteLine(ciphertext);
            Console.WriteLine("");
            Console.WriteLine(decrypted_text);
        }*/
    }
}
