using System.Numerics;
using System.Text;

class RSA
{
    BigInteger p = 61;
    BigInteger q = 53;
    BigInteger n;
    BigInteger phi;
    BigInteger e = 17;
    BigInteger d;

    public RSA()
    {
        n = p * q;
        phi = (p - 1) * (q - 1);
        d = Inv(e, phi);
    }

    BigInteger Inv(BigInteger a, BigInteger m)
    {
        BigInteger m0 = m, y = 0, x = 1;
        while (a > 1)
        {
            BigInteger q = a / m;
            (a, m) = (m, a % m);
            (x, y) = (y, x - q * y);
        }
        if (x < 0) x += m0;
        return x;
    }

    public BigInteger Encrypt(BigInteger m)
    {
        return BigInteger.ModPow(m, e, n);
    }

    public BigInteger Decrypt(BigInteger c)
    {
        return BigInteger.ModPow(c, d, n);
    }

    public string EncryptString(string text)
    {
        byte[] data = Encoding.UTF8.GetBytes(text);
        List<string> r = new List<string>();

        foreach (byte b in data)
        {
            BigInteger c = BigInteger.ModPow(b, e, n);
            r.Add(c.ToString());
        }
        return string.Join("|", r);
    }

    public string DecryptString(string cipher)
    {
        string[] parts = cipher.Split('|');
        List<byte> r = new List<byte>();

        foreach (string p in parts)
        {
            BigInteger c = BigInteger.Parse(p);
            BigInteger m = BigInteger.ModPow(c, d, n);
            r.Add((byte)m);
        }
        return Encoding.UTF8.GetString(r.ToArray());
    }
}
