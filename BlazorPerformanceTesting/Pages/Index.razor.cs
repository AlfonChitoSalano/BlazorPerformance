namespace BlazorPerformanceTesting.Pages
{
    public partial class Index
    {
        private const string TextString =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.";

        private readonly Random _random = new();

        private static int _counter;
        private bool _isDraw;
        private bool _isDrawUsingMarkUp;
        private string? _markUpElements;

        private void Draw()
        {
            _isDraw = true;
            _isDrawUsingMarkUp = false;
        }

        private void DrawUsingMarkUpString()
        {
            _isDraw = false;
            _isDrawUsingMarkUp = true;
            ++_counter;

            using (new ExecutionTimeLogger($"DrawUsingMarkUpString {_counter}"))
            {
                for (var i = 0; i < 5000; i++)
                {
                    var divSizeInPx = $"{_random.Next(50, 150)}px";
                    var newElem =
                        $"<div style=\"height: {divSizeInPx}; width: {divSizeInPx};overflow:hidden; margin:1px;border:1px solid #000;padding:2px;float:left\">{TextString}</div>";
                    _markUpElements += newElem;
                }
            }
        }
    }
}