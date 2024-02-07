﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnitPrice4.  ISO2002 ID# _U4glFNp-Ed-ak6NoX_4Aeg_-1557165466.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
public partial record UnitPrice4
     : IIsoXmlSerilizable<UnitPrice4>
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    public required TypeOfPrice8Code Type { get; init; } 
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    public required PriceValue1 Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Val", xmlNamespace );
        Value.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static UnitPrice4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
