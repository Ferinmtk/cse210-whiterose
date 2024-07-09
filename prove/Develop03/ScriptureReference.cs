public class ScriptureReference
{
    public string Reference { get; private set; }

    public ScriptureReference(string reference)
    {
        Reference = reference;
    }

    // Constructor to handle both single verse and verse range
    public ScriptureReference(string book, int chapter, int verse)
    {
        Reference = $"{book} {chapter}:{verse}";
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Reference = $"{book} {chapter}:{startVerse}-{endVerse}";
    }

    public override string ToString()
    {
        return Reference;
    }
}
