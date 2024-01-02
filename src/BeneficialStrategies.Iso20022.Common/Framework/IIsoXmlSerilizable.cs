
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Common.Framework;

//public interface IIsoXmlSerializer<TTypeToSerialize>
//{
//    static abstract Task SerializeAsync(XmlWriter xmlWriter, TTypeToSerialize objectToSerialize);
//    static abstract Task<TTypeToSerialize> DeserializeAsync(XmlReader reader);
//    static abstract TTypeToSerialize Deserialize(XElement element);
//}

public interface IIsoXmlSerilizable<TSelf>
{
    Task SerializeAsync(XmlWriter xmlWriter);
    static abstract TSelf Deserialize(XElement element);
    static abstract Task<TSelf> DeserializeAsync(XmlReader reader);
    static abstract XName RootElement { get; }
}

//public static class IsoXmlSerializerExtensionMethods<TTypeToSerialize>
//    where TTypeToSerialize : IIsoXmlSerilizable<TTypeToSerialize>
//{

//    public static async Task<TTypeToSerialize> DeserializeAsync(XmlReader reader)
//    {
//        var xDoc = await XDocument.LoadAsync(reader, new LoadOptions { }, CancellationToken.None);

//        return TTypeToSerialize.Deserialize(xDoc.Root ?? throw new Exception("No root"));
//    }
//}

//public record MyClass
//{
//    public required string Name { get; init; }
//}

//public class MyClassSerializer : IIsoXmlSerializer<MyClass>
//{
//    public static async Task<MyClass> DeserializeAsync(XmlReader reader)
//    {
//        var xDoc = await XDocument.LoadAsync(reader, new LoadOptions { }, CancellationToken.None);

//        return Deserialize(xDoc.Root ?? throw new Exception("No root"));
//    }

//    public static MyClass Deserialize(XElement element)
//    { 
//        var value = new MyClass
//        {
//            Name = element.Value
//        };
//        return value;
//    }

//    public static async Task SerializeAsync(XmlWriter xmlWriter, MyClass objectToSerialize)
//    {
//        await xmlWriter.WriteElementStringAsync(null, "abc",null, objectToSerialize.Name);
//    }
//}