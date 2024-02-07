﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProductCharacteristics1.  ISO2002 ID# _T5L2FNp-Ed-ak6NoX_4Aeg_1219351972.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the characteristic of a product.
/// </summary>
public partial record ProductCharacteristics1
     : IIsoXmlSerilizable<ProductCharacteristics1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of product characteristic by means of a code.
    /// </summary>
    public required ProductCharacteristics1Code Type { get; init; } 
    /// <summary>
    /// Specifies the characteristic of a product.
    /// </summary>
    public required IsoMax35Text Characteristics { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Chrtcs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Characteristics)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static ProductCharacteristics1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
