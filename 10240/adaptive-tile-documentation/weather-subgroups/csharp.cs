...

TileWide = new TileBinding()
{
    DisplayName = "Seattle",
    Branding = TileBranding.Name,
    Content = new TileBindingContentAdaptive()
    {
        Children =
        {
            new TileGroup()
            {
                Children =
                {
                    CreateSubgroup("Mon", "Mostly Cloudy.png", "63°", "42°"),

                    CreateSubgroup("Tue", "Cloudy.png", "57°", "38°"),

                    CreateSubgroup("Wed", "Sunny.png", "59°", "43°"),

                    CreateSubgroup("Thu", "Sunny.png", "62°", "42°"),

                    CreateSubgroup("Fri", "Sunny.png", "71°", "66°")
                }
            }
        }
    }
}

...


private static TileSubgroup CreateSubgroup(string day, string image, string highTemp, string lowTemp)
{
    return new TileSubgroup()
    {
        Weight = 1,

        Children =
        {
            new TileText()
            {
                Text = day,
                Align = TileTextAlign.Center
            },

            new TileImage()
            {
                Source = new TileImageSource("Assets/Weather/" + image),
                RemoveMargin = true
            },

            new TileText()
            {
                Text = highTemp,
                Align = TileTextAlign.Center
            },

            new TileText()
            {
                Text = lowTemp,
                Align = TileTextAlign.Center,
                Style = TileTextStyle.CaptionSubtle
            }
        }
    };
}