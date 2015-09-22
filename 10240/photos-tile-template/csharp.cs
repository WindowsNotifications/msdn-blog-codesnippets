/*

To use the Photos template...

 - On any TileBinding object
   - Set Content property to new instance of TileBindingContentPhotos
   - Add up to 12 images to Images property of TileBindingContentPhotos.

*/

TileContent content = new TileContent()
{
    Visual = new TileVisual()
    {
        TileMedium = new TileBinding()
        {
            Content = new TileBindingContentPhotos()
            {
                Images =
                {
                    new TileImageSource("Assets/1.jpg"),
                    new TileImageSource("ms-appdata:///local/Images/2.jpg"),
                    new TileImageSource("http://msn.com/images/3.jpg")

                    // TODO: Can have 12 images total
                }
            }
        }

        // TODO: Add other tile sizes
    }
};