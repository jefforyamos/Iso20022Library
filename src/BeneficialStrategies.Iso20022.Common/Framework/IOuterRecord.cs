using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Framework
{
    /// <summary>
    /// Should be implemented on all messages that are the main incoming or outgoing message of the hierarchy.  
    /// </summary>
    public interface IOuterRecord
    {
    }


    /// <summary>
    /// Should adorn the implemenation of the top level record that has the main message data.
    /// </summary>
    /// <typeparam name="TSelf">Data type being decorated with the interface.</typeparam>
    /// <typeparam name="TMessageDocType">Document wrapper type that will be instanced.</typeparam>
    public interface IOuterRecord<TSelf, TMessageDocType> : IOuterRecord
        where TMessageDocType : IOuterDocument<TSelf>
        where TSelf : IOuterRecord
    {
        /// <summary>
        /// Envelope this message inside it's serialization wrapper.
        /// </summary>
        /// <returns>Returns an outer document with this message as it's message payload.</returns>
        TMessageDocType ToDocument();

    }


#if DECLARE_INTERNALSERIALIZATION
    public interface ISerializeInsideARootElement
    {
           /// <summary>
        /// Returns the normal root element for this record type.
        /// </summary>
        static abstract XName RootElement { get; }

        static abstract string IsoXmlNamspace { get; }

    }
#endif
}