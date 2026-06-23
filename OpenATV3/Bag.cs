using Claunia.PropertyList;

namespace OpenATV3;

public class Bag
{
    // just enough plist for the atv (basic replication of ATV trailers)
    public void GenerateBag(string filePath)
    {
        // create root object
        NSDictionary root = new NSDictionary();
        root.Add("auth-type","http");
        root.Add("enabled","YES");
        root.Add("log-url","http://localhost:8080/");
        root.Add("menu-title","test");
        root.Add("merchant","test");
        root.Add("root-url","http://localhost:8080/index.xml");
        // optional js to add
        NSDictionary js = new NSDictionary();
        js.Add("javascript-url", "http://localhost:8080/index.js");
        root.Add("vendor-gk-3", js);
        PropertyListParser.SaveAsXml(root, new FileInfo(filePath));
    }
}