namespace GabrovoUltraWebApp.Infrastructure.Common
{
    public static class DataValidationConstants
    {
        public static class Race
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;

            public const int DescriptionMaxLength = 250;
            public const int DescriptionMinLength = 5;

            public const int LocationMaxLength = 100;
            public const int LocationMinLength = 5;
        }

        public static class HeroSection
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;
            public const int DescriptionMaxLength = 250;
            public const int DescriptionMinLength = 5;
        }

        public static class Distance
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;

            public const int DescriptionMaxLength = 250;
            public const int DescriptionMinLength = 5;

            public const int LengthMaxValue = 160;
            public const int LengthMinValue = 5;

            public const string StartTimeRegex = @"^(?:[01][0-9]|2[0-3]):[0-5][0-9]$";
        }
    }
}
