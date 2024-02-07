﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CurrencyAndAmountRange.  ISO2002 ID# _PPV2VZlcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ActiveOrHistoricAmountRange2Choice;

/// <summary>
/// Expresses an amount or an amount range with the currency and where the credit/debit indicator is explicit.
/// </summary>
public partial record CurrencyAndAmountRange : ActiveOrHistoricAmountRange2Choice_
     , IIsoXmlSerilizable<CurrencyAndAmountRange>
{
    #nullable enable
    
    /// <summary>
    /// Specified amount or amount range.
    /// </summary>
    public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; } 
    /// <summary>
    /// Indicates whether the amount is a credited or debited amount.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Medium of exchange of value, used to qualify an amount.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    
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
        Amount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CreditDebitIndicator is CreditDebitCode CreditDebitIndicatorValue)
        {
            writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
            writer.WriteValue(CreditDebitIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Ccy", xmlNamespace );
        writer.WriteValue(Currency.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new CurrencyAndAmountRange Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
