﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SignedQuantityFormat15.  ISO2002 ID# _eXQn8zT5Ee2j2eQlcOSMKg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed quantity of a security for various quantity formats.
/// </summary>
public partial record SignedQuantityFormat15
     : IIsoXmlSerilizable<SignedQuantityFormat15>
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of securities.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of securities.
    /// </summary>
    public required FinancialInstrumentQuantity46Choice_ Quantity { get; init; } 
    
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
        writer.WriteStartElement(null, "ShrtLngPos", xmlNamespace );
        writer.WriteValue(ShortLongPosition.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        Quantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SignedQuantityFormat15 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
