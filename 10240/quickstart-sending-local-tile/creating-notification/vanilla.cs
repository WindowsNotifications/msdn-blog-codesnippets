// Load the string into an XmlDocument
XmlDocument doc = new XmlDocument();
doc.LoadXml(content);

// Then create the tile notification
var notification = new TileNotification(doc);