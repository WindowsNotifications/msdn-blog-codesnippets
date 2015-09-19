...

TileMedium = new TileBinding()
{
    Branding = TileBranding.Logo,

    Content = new TileBindingContentAdaptive()
    {
        TextStacking = TileTextStacking.Center,

        Children =
        {
            new TileText()
            {
                Text = "Hi,",
                Style = TileTextStyle.Base,
                Align = TileTextAlign.Center
            },

            new TileText()
            {
                Text = "MasterHip",
                Style = TileTextStyle.CaptionSubtle,
                Align = TileTextAlign.Center
            }
        }
    }
}

...