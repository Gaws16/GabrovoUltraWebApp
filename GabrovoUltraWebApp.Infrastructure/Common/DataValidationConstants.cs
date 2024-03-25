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

            public const string DateTimeFormat = "dd/MM/yyyy";
        }

        public static class HeroSection
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;
            public const int DescriptionMaxLength = 250;
            public const int DescriptionMinLength = 5;

            public const string ValidateImageUrlRegex= @"^\/[a-zA-Z0-9]+(?:\.jpg|\.png|\.webp|\.gif)$";
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

        public static class Runner
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;

            public const int TeamMaxLength = 50;
            public const int TeamMinLength = 5;

            public const int StartingNumberMaxLength = 6;
            public const int StartingNumberMinLength = 1;

            public const int CategoryMaxLength = 50;
            public const int CategoryMinLength = 5;
        }
    }
}
