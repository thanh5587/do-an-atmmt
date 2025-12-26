using System;
using System.Collections.Generic;
using System.Text;

class PlayfairCipher
{
    char[,] m = new char[5, 5];
    Dictionary<char, (int, int)> p = new Dictionary<char, (int, int)>();

    public PlayfairCipher(string key)
    {
        key = key.ToUpper().Replace("J", "I");
        string s = "";
        foreach (char c in key)
            if (c >= 'A' && c <= 'Z' && !s.Contains(c))
                s += c;

        for (char c = 'A'; c <= 'Z'; c++)
            if (c != 'J' && !s.Contains(c))
                s += c;

        int k = 0;
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                m[i, j] = s[k];
                p[s[k]] = (i, j);
                k++;
            }
    }

    string Prep(string t)
    {
        t = t.ToUpper().Replace("J", "I");
        StringBuilder r = new StringBuilder();

        foreach (char c in t)
        {
            if (c >= 'A' && c <= 'Z')
                r.Append(c);
        }

        for (int i = 0; i < r.Length - 1; i += 2)
        {
            if (r[i] == r[i + 1])
                r.Insert(i + 1, 'X');
        }

        if (r.Length % 2 == 1)
            r.Append('X');

        return r.ToString();
    }
    string Clean(string t)
    {
        StringBuilder r = new StringBuilder();
        foreach (char c in t.ToUpper())
            if (c >= 'A' && c <= 'Z')
                r.Append(c);
        return r.ToString();
    }

    string RemoveX(string t)
    {
        StringBuilder r = new StringBuilder();

        for (int i = 0; i < t.Length; i++)
        {
            if (i > 0 && i < t.Length - 1 &&
                t[i] == 'X' &&
                t[i - 1] == t[i + 1])
                continue;

            r.Append(t[i]);
        }

        if (r.Length > 0 && r[r.Length - 1] == 'X')
            r.Remove(r.Length - 1, 1);

        return r.ToString();
    }


    public string Encrypt(string t)
    {
        t = Prep(Clean(t));
        StringBuilder r = new StringBuilder();

        for (int i = 0; i < t.Length; i += 2)
        {
            var a = p[t[i]];
            var b = p[t[i + 1]];

            if (a.Item1 == b.Item1)
                r.Append(m[a.Item1, (a.Item2 + 1) % 5])
                 .Append(m[b.Item1, (b.Item2 + 1) % 5]);
            else if (a.Item2 == b.Item2)
                r.Append(m[(a.Item1 + 1) % 5, a.Item2])
                 .Append(m[(b.Item1 + 1) % 5, b.Item2]);
            else
                r.Append(m[a.Item1, b.Item2])
                 .Append(m[b.Item1, a.Item2]);
        }
        return r.ToString();
    }

    public string Decrypt(string t)
    {
        t = Clean(t);
        StringBuilder r = new StringBuilder();

        for (int i = 0; i < t.Length; i += 2)
        {
            var a = p[t[i]];
            var b = p[t[i + 1]];

            if (a.Item1 == b.Item1)
                r.Append(m[a.Item1, (a.Item2 + 4) % 5])
                 .Append(m[b.Item1, (b.Item2 + 4) % 5]);
            else if (a.Item2 == b.Item2)
                r.Append(m[(a.Item1 + 4) % 5, a.Item2])
                 .Append(m[(b.Item1 + 4) % 5, b.Item2]);
            else
                r.Append(m[a.Item1, b.Item2])
                 .Append(m[b.Item1, a.Item2]);
        }

        return RemoveX(r.ToString());
    }



}
