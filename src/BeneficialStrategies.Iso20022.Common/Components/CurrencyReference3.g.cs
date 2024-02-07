﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyReference3.  ISO2002 ID# _oVtgQWoQEea5EcY2TpG1mw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the process of a currency exchange or conversion.
/// </summary>
public partial record CurrencyReference3
     : IIsoXmlSerilizable<CurrencyReference3>
{
    #nullable enable
    
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    public required ActiveCurrencyCode TargetCurrency { get; init; } 
    /// <summary>
    /// Currency of the amount to be converted in a currency conversion.
    /// </summary>
    public required ActiveCurrencyCode SourceCurrency { get; init; } 
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    public ExchangeRateInformation1? ExchangeRateInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "TrgtCcy", xmlNamespace );
        writer.WriteValue(TargetCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SrcCcy", xmlNamespace );
        writer.WriteValue(SourceCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        if (ExchangeRateInformation is ExchangeRateInformation1 ExchangeRateInformationValue)
        {
            writer.WriteStartElement(null, "XchgRateInf", xmlNamespace );
            ExchangeRateInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CurrencyReference3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
