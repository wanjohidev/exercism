public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(Object obj)
    {
        return obj is FacialFeatures features &&
            EyeColor == features.EyeColor &&
            PhiltrumWidth == features.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(Object obj)
    {
        return obj is Identity identity &&
            Email == identity.Email &&
            FacialFeatures.Equals(identity.FacialFeatures);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }
    
}

public class Authenticator
{
    private HashSet<Identity> identities = new HashSet<Identity>();
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return identity.Equals(
            new Identity("admin@exerc.ism", 
            new FacialFeatures("green", 0.9m))
        );
    }

    public bool Register(Identity identity)
    {
        return identities.Add(identity);
    }

    public bool IsRegistered(Identity identity)
    {
        return identities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA == identityB;
    }
}
