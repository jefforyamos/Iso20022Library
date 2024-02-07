﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyConversion10.  ISO2002 ID# _9iPWIa4YEeW_TaP-ygI0SQ.
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
public partial record CurrencyConversion10
     : IIsoXmlSerilizable<CurrencyConversion10>
{
    #nullable enable
    
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    public required CurrencyConversionResponse2Code Result { get; init; } 
    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    public IsoMax35Text? ResultReason { get; init; } 
    /// <summary>
    /// Information about the conversion of currency.
    /// </summary>
    public CurrencyConversion9? Conversion { get; init; } 
    
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
        if (Conversion is CurrencyConversion9 ConversionValue)
        {
            writer.WriteStartElement(null, "Convs", xmlNamespace );
            ConversionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CurrencyConversion10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
