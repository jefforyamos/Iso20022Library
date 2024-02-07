﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndCurrencyExchangeDetails2.  ISO2002 ID# _SVWEytp-Ed-ak6NoX_4Aeg_-345262172.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information on the original amount and currency information.
/// </summary>
public partial record AmountAndCurrencyExchangeDetails2
     : IIsoXmlSerilizable<AmountAndCurrencyExchangeDetails2>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of amount.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Identifies the proprietary amount.
    /// </summary>
    public required IsoCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    public CurrencyExchange3? CurrencyExchange { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(Amount)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (CurrencyExchange is CurrencyExchange3 CurrencyExchangeValue)
        {
            writer.WriteStartElement(null, "CcyXchg", xmlNamespace );
            CurrencyExchangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AmountAndCurrencyExchangeDetails2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
