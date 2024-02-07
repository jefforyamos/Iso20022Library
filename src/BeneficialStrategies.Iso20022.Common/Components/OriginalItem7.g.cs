﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalItem7.  ISO2002 ID# _flAIsdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification item, to which the cancellation advice refers.
/// </summary>
public partial record OriginalItem7
     : IIsoXmlSerilizable<OriginalItem7>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the original notification item.
    /// </summary>
    public required IsoMax35Text OriginalItemIdentification { get; init; } 
    /// <summary>
    /// Unique identification as assigned by the debtor to unambiguously identify the original underlying transaction to the creditor.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? UETR { get; init; } 
    /// <summary>
    /// Amount of money expected to be credited to the account, as per the original notification to receive.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Value date on which the account was expected to be credited.
    /// </summary>
    public IsoISODate? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Provides further information in order to identify a previous payment notification.
    /// </summary>
    public OriginalItemReference6? OriginalItemReference { get; init; } 
    
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
        writer.WriteStartElement(null, "OrgnlItmId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalItemIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginalEndToEndIdentification is IsoMax35Text OriginalEndToEndIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlEndToEndId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalEndToEndIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (UETR is IsoUUIDv4Identifier UETRValue)
        {
            writer.WriteStartElement(null, "UETR", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoUUIDv4Identifier(UETRValue)); // data type UUIDv4Identifier System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Amount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (ExpectedValueDate is IsoISODate ExpectedValueDateValue)
        {
            writer.WriteStartElement(null, "XpctdValDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ExpectedValueDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (OriginalItemReference is OriginalItemReference6 OriginalItemReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlItmRef", xmlNamespace );
            OriginalItemReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OriginalItem7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
