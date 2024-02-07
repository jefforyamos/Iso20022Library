﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryQuantity.  ISO2002 ID# _pf0YvTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Quantity80Choice;

/// <summary>
/// Proprietary quantity of security format.
/// </summary>
public partial record ProprietaryQuantity : Quantity80Choice_
     , IIsoXmlSerilizable<ProprietaryQuantity>
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public ShortLong1Code? ShortLongPosition { get; init; } 
    /// <summary>
    /// Provides the proprietary quantity with a decimal number.
    /// </summary>
    public required IsoRestrictedFINDecimalNumber Quantity { get; init; } 
    /// <summary>
    /// Identifies the type of proprietary quantity reported.
    /// </summary>
    public required IsoExact4AlphaNumericText QuantityType { get; init; } 
    /// <summary>
    /// Provides information related to issuer in free format.
    /// </summary>
    public required IsoMax4AlphaNumericText Issuer { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax4AlphaNumericText? SchemeName { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (ShortLongPosition is ShortLong1Code ShortLongPositionValue)
        {
            writer.WriteStartElement(null, "ShrtLngPos", xmlNamespace );
            writer.WriteValue(ShortLongPositionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINDecimalNumber(Quantity)); // data type RestrictedFINDecimalNumber System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "QtyTp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact4AlphaNumericText(QuantityType)); // data type Exact4AlphaNumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Issr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(Issuer)); // data type Max4AlphaNumericText System.String
        writer.WriteEndElement();
        if (SchemeName is IsoMax4AlphaNumericText SchemeNameValue)
        {
            writer.WriteStartElement(null, "SchmeNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(SchemeNameValue)); // data type Max4AlphaNumericText System.String
            writer.WriteEndElement();
        }
    }
    public static new ProprietaryQuantity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
