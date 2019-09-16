namespace PhoneExercises
{
    public class Screen
    {
        public decimal Size { get; }
        public ScreenColor ColorConfiguration { get; }
        public Screen(decimal size, ScreenColor colorConfiguration = ScreenColor.Color)
        {
            Size = size;
            ColorConfiguration = colorConfiguration;
        }
    }
}