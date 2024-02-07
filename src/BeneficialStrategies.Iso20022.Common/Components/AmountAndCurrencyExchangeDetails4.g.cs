﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndCurrencyExchangeDetails4.  ISO2002 ID# _SWFrptp-Ed-ak6NoX_4Aeg_-2139849046.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original amount and currency exchange.
/// </summary>
public partial record AmountAndCurrencyExchangeDetails4
     : IIsoXmlSerilizable<AmountAndCurrencyExchangeDetails4>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of amount.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Amount of money to be exchanged against another amount of money in the counter currency.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Set of elements used to provide details on the currency exchange.
    /// </summary>
    public CurrencyExchange5? CurrencyExchange { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Type)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Amount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (CurrencyExchange is CurrencyExchange5 CurrencyExchangeValue)
        {
            writer.WriteStartElement(null, "CcyXchg", xmlNamespace );
            CurrencyExchangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AmountAndCurrencyExchangeDetails4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
