class NameFormatter
{
    public string Format(List<string> names)
    {
        /*
         * Builds a single string from the list of name.
         */
        return string.Join(Environment.NewLine, names);
    }
}
