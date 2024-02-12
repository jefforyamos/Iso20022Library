using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022
{
    /// <summary>
    /// Extends the normal list by using value-based equality.  Also uses Iso20022 serialization.
    /// </summary>
    /// <typeparam name="T">The data type of items in the collection.</typeparam>
    public class ValueList<T> : List<T>
#if DECLARE_INTERNALSERIALIZATION
        , IIsoXmlSerilizable<ValueList<T>>
         where T: IIsoXmlSerilizable<T>
#endif
    {
        //private readonly bool _requireMathcingOrder;
        public ValueList()
        {
        
        }
        public ValueList(IEnumerable<T> collection) : base(collection)
        {
        }

        public ValueList(int capacity) : base(capacity)
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
        #if DECLARE_INTERNALSERIALIZATION
        /// <summary>
        /// Serializes the collection one item at a time based using the Iso20022 standard serialization.
        /// </summary>
        /// <param name="writer">The xml writer to write to.</param>
        /// <param name="xmlNamespace">The XML namespace for the message we are currently persisting.</param>
        public void Serialize(XmlWriter writer, string xmlNamespace)
        {
            foreach( var item in this)
            {
                item.Serialize(writer, xmlNamespace);
            }
        }

        /// <summary>
        /// Deserializes the collection one item at a time.
        /// </summary>
        /// <param name="element">Element that has the container of child elements.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static ValueList<T> Deserialize(XElement element)
        {
            var list = new ValueList<T>();
            foreach( var child in element.Elements())
            {
                var newItem = T.Deserialize(child);
                list.Add(newItem);
            }
            return list;
        }
        #endif 
    }
}
