// In a real app, these would be initialized with actual data
string from = "Jennifer Parker";
string subject = "Photos from our trip";
string body = "Check out these awesome photos I took while in New Zealand!";


// TODO - all values need to be XML escaped


// Construct the tile content as a string
string content = $@"
<tile>
    <visual>

        <binding template='TileMedium'>
            <text>{from}</text>
            <text hint-style='captionSubtle'>{subject}</text>
            <text hint-style='captionSubtle'>{body}</text>
        </binding>

        <binding template='TileWide'>
            <text hint-style='subtitle'>{from}</text>
            <text hint-style='captionSubtle'>{subject}</text>
            <text hint-style='captionSubtle'>{body}</text>
        </binding>

    </visual>
</tile>";