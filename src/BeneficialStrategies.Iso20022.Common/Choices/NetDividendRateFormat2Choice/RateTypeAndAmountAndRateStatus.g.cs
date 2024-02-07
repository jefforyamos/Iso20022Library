﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _UM2Y-Np-Ed-ak6NoX_4Aeg_-628426868.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat2Choice;

/// <summary>
/// Specifies different formats for the net dividend rate.
/// </summary>
public partial record RateTypeAndAmountAndRateStatus : NetDividendRateFormat2Choice_
     , IIsoXmlSerilizable<RateTypeAndAmountAndRateStatus>
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required RateType7Choice_ RateType { get; init; } 
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public RateStatus1Choice_? RateStatus { get; init; } 
    
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
        writer.WriteStartElement(null, "RateTp", xmlNamespace );
        RateType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(Amount)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        if (RateStatus is RateStatus1Choice_ RateStatusValue)
        {
            writer.WriteStartElement(null, "RateSts", xmlNamespace );
            RateStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new RateTypeAndAmountAndRateStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
