﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotEligibleBalance.  ISO2002 ID# _kvec4Tq5EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat5Choice;

/// <summary>
/// Provide not eligible balance information in different formats.
/// </summary>
public partial record NotEligibleBalance : BalanceFormat5Choice_
     , IIsoXmlSerilizable<NotEligibleBalance>
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    
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
        writer.WriteStartElement(null, "ShrtLngPos", xmlNamespace );
        writer.WriteValue(ShortLongPosition.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        Quantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new NotEligibleBalance Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
