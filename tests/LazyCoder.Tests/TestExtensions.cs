using LazyCoder.Writers;

namespace LazyCoder.Tests
{
    public static class TestExtensions
    {
        public static void ShouldBeTranslatedTo<T>(this T tsThing, params string[] lines)
        {
            var writerContext = new WriterContext();
            writerContext.Write(tsThing);
            var result = writerContext.GetResult().Trim();
            result.ShouldBeLines(lines);
        }
    }
}
