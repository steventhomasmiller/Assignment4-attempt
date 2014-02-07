using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;//where you get the hashes, as it were.

/// <summary>
/// Summary description for Class1
/// </summary>
public class PasswordHash//a.k.a. PasswordHash
{
    private string passwd; //integer in database, but must be concatenated
    private string passkey;

    public Byte[] Hashit(string password, string passkey)
    {
        passwd = password;
        this.passkey = passkey;

        Byte[] originalBytes;
        Byte[] encodedBytes;

        SHA512 shaHash = SHA512.Create();

        string passToHash = passkey + passwd;

        originalBytes = ASCIIEncoding.Default.GetBytes(passToHash);//takes string you pass to it, turns it to byte array
        encodedBytes = shaHash.ComputeHash(originalBytes);//takes string, stores in byte array, "messes it up."

        return encodedBytes;
    }
   
}