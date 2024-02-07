﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTypeAndIdentification21.  ISO2002 ID# _cfvuM5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall process covering the trade and settlement transactions of financial instruments.
/// </summary>
public partial record SettlementTypeAndIdentification21
     : IIsoXmlSerilizable<SettlementTypeAndIdentification21>
{
    #nullable enable
    
    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Reference of the transaction.
    /// </summary>
    public required IsoRestrictedFINXMax16Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Identifies the intended settlement date.
    /// </summary>
    public DateAndDateTimeChoice_? SettlementDate { get; init; } 
    
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
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TransactionIdentification)); // data type RestrictedFINXMax16Text System.String
        writer.WriteEndElement();
        if (SettlementDate is DateAndDateTimeChoice_ SettlementDateValue)
        {
            writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
            SettlementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementTypeAndIdentification21 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
