...

TileWide = new TileBinding()
{
    Branding = TileBranding.Name,

    Content = new TileBindingContentAdaptive()
    {
        PeekImage = new TilePeekImage()
        {
            Source = new TileImageSource("Assets/Apps/Hipstame/hipster.jpg")
        },

        Children =
        {
            new TileText()
            {
                Text = "New Message"
            },

            new TileText()
            {
                Text = "Hey, have you tried Windows 10 yet?",
                Style = TileTextStyle.CaptionSubtle,
                Wrap = true
            }
        }
    }
}

...