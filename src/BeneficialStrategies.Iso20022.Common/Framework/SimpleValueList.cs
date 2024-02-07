using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Extends the normal list by using value-based equality.  Also uses Iso20022 serialization.
/// </summary>
/// <typeparam name="T">The data type of items in the collection.</typeparam>
public class SimpleValueList<T> : List<T>
{
    //private readonly bool _requireMathcingOrder;
    public SimpleValueList()
    {
    }

    public SimpleValueList(IEnumerable<T> collection) : base(collection)
    {
    }

    public SimpleValueList(int capacity) : base(capacity)
    {
    }

    /// <summary>
    /// Overridden to do value-based equality.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public override bool Equals(object? other)
    {
        if (other is null) return false;
        if (!(other is IEnumerable<T> enumerable)) return false;
        // if(!_requireMathcingOrder)return enumerable.ScrambledEquals(this);
        return enumerable.SequenceEqual(this);
    }

    public override int GetHashCode()
    {
        var hashCode = 0;
        foreach (var item in this)
        {
            hashCode ^= item?.GetHashCode() ?? 0;
        }

        return hashCode;
    }

    /// <summary>
    /// Serializes the collection one item at a time based using the Iso20022 standard serialization.
    /// </summary>
    /// <param name="writer">The xml writer to write to.</param>
    /// <param name="xmlNamespace">The XML namespace for the message we are currently persisting.</param>
    public void Serialize(XmlWriter writer, string xmlNamespace, string itemEnclosingElementName, Func<T,string> serializationFormatter)
    {
        foreach( var item in this)
        {
            // Todo: Need to get SerializationFormatter involved here.
            if ( item is not null ) writer.WriteElementString(itemEnclosingElementName, xmlNamespace, serializationFormatter(item) );
        }
    }

    /// <summary>
    /// Deserializes the collection one item at a time.
    /// </summary>
    /// <param name="element">Element that has the container of child elements.</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static SimpleValueList<T> Deserialize(XElement element)
    {
        // var list = new ValueList<T>();
        // foreach( var child in element.Elements())
        // {
        //     var newItem = T.Deserialize(child);
        //     list.Add(newItem);
        // }
        // return list;
        throw new NotImplementedException();
    }
}
