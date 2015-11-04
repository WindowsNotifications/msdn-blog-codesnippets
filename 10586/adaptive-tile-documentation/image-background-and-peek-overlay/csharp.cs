...

TileMedium = new TileBinding()
{
    Content = new TileBindingContentAdaptive()
    {
        BackgroundImage = new TileBackgroundImage()
        {
            Source = new TileImageSource("Assets/Mostly Cloudy-Background.jpg"),
            Overlay = 60
        },
        
        PeekImage = new TilePeekImage()
        {
            Source = new TileImageSource("Assets/Map.jpg"),
            Overlay = 20
        },

        ...
    }
}

...