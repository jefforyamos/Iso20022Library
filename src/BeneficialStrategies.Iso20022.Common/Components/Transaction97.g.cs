﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction97.  ISO2002 ID# _gfNI4VBQEeedyPuM0kK2EQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
public partial record Transaction97
     : IIsoXmlSerilizable<Transaction97>
{
    #nullable enable
    
    /// <summary>
    /// Reason for sending the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    public IsoExact4NumericText? MessageReason { get; init; } 
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification10 TransactionIdentification { get; init; } 
    /// <summary>
    /// Transaction amounts.
    /// </summary>
    public required TransactionAmounts1 TransactionAmounts { get; init; } 
    /// <summary>
    /// Data related to the dispute.
    /// </summary>
    public required DisputeData1 DisputeData { get; init; } 
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    public AdditionalFee1? AdditionalFees { get; init; } 
    /// <summary>
    /// Additional information related to the chargeback.
    /// </summary>
    public AdditionalInformation20? AdditionalInformation { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    
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
        if (MessageReason is IsoExact4NumericText MessageReasonValue)
        {
            writer.WriteStartElement(null, "MsgRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact4NumericText(MessageReasonValue)); // data type Exact4NumericText System.String
            writer.WriteEndElement();
        }
        if (AlternateMessageReason is IsoMax35Text AlternateMessageReasonValue)
        {
            writer.WriteStartElement(null, "AltrnMsgRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AlternateMessageReasonValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxAmts", xmlNamespace );
        TransactionAmounts.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DsptData", xmlNamespace );
        DisputeData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalFees is AdditionalFee1 AdditionalFeesValue)
        {
            writer.WriteStartElement(null, "AddtlFees", xmlNamespace );
            AdditionalFeesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation20 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Transaction97 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
