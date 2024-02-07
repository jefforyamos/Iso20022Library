﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyConversion22.  ISO2002 ID# _UAyYoS8_Eeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider.
/// </summary>
public partial record CurrencyConversion22
     : IIsoXmlSerilizable<CurrencyConversion22>
{
    #nullable enable
    
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    public required CurrencyConversionResponse3Code Result { get; init; } 
    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    public IsoMax35Text? ResultReason { get; init; } 
    /// <summary>
    /// Information about the conversion of currency.
    /// </summary>
    public CurrencyConversion20? ConversionDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "Rslt", xmlNamespace );
        writer.WriteValue(Result.ToString()); // Enum value
        writer.WriteEndElement();
        if (ResultReason is IsoMax35Text ResultReasonValue)
        {
            writer.WriteStartElement(null, "RsltRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ResultReasonValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ConversionDetails is CurrencyConversion20 ConversionDetailsValue)
        {
            writer.WriteStartElement(null, "ConvsDtls", xmlNamespace );
            ConversionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CurrencyConversion22 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
