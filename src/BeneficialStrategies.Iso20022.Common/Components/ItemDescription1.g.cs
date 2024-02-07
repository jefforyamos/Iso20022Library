﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ItemDescription1.  ISO2002 ID# _22xaAPM8EeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Language, title and textual description in the specified language of an item.
/// </summary>
public partial record ItemDescription1
     : IIsoXmlSerilizable<ItemDescription1>
{
    #nullable enable
    
    /// <summary>
    /// Language used to provide a description of the item and specified in the ISO 639-1 language code standard.
    /// </summary>
    public required ISO2ALanguageCode Language { get; init; } 
    /// <summary>
    /// Abbreviated description of the item.
    /// </summary>
    public IsoMax350Text? Title { get; init; } 
    /// <summary>
    /// Free textual description of the item in the specified language.
    /// </summary>
    public IsoMax1025Text? Description { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Lang", xmlNamespace );
        writer.WriteValue(Language.ToString()); // Enum value
        writer.WriteEndElement();
        if (Title is IsoMax350Text TitleValue)
        {
            writer.WriteStartElement(null, "Titl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(TitleValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (Description is IsoMax1025Text DescriptionValue)
        {
            writer.WriteStartElement(null, "Desc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1025Text(DescriptionValue)); // data type Max1025Text System.String
            writer.WriteEndElement();
        }
    }
    public static ItemDescription1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
