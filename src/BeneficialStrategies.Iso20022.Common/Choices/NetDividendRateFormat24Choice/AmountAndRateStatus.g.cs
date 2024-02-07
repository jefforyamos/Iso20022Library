﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountAndRateStatus.  ISO2002 ID# _zCJUQWXGEeWht50_j0HXAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat24Choice;

/// <summary>
/// Specifies an amount and a rate status.
/// </summary>
public partial record AmountAndRateStatus : NetDividendRateFormat24Choice_
     , IIsoXmlSerilizable<AmountAndRateStatus>
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public required RateStatus1Code RateStatus { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(Amount)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RateSts", xmlNamespace );
        writer.WriteValue(RateStatus.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new AmountAndRateStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
