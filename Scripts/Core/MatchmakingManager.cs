using Godot;
using System;

namespace ZZParty;

public partial class MatchmakingManager : Node
{
    public event Action<string> OnCodeGenere;

    private readonly Random _random = new Random();
    private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public string GenererCodeSalon()
    {
        char[] stringChars = new char[4];
        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = Chars[_random.Next(Chars.Length)];
        }
        string code = new string(stringChars);

        OnCodeGenere?.Invoke(code);

        return code;
    }

    public bool ValiderFormatCode(string code)
    {
        if (string.IsNullOrEmpty(code))
        {
            return false;
        }

        if (code.Contains(' '))
        {
            return false;
        }

        if (code.Length != 4)
        {
            return false;
        }

        foreach (char c in code)
        {
            if (c < 'A' || c > 'Z')
            {
                return false;
            }
        }

        return true;
    }
}
