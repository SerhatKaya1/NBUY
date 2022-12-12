namespace ShoppingApp.Core
{
    internal interface IFormFile
    {
        ReadOnlySpan<char> FileName { get; }
    }
}