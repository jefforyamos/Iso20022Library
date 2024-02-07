﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalDataElements1.  ISO2002 ID# _n6z5AESCEeeb1MmUPTrSMw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data elements contained in the original message.
/// ISO 8583:1987 bit 90 and ISO 8583 1993/2003 bit 56.
/// </summary>
public partial record OriginalDataElements1
     : IIsoXmlSerilizable<OriginalDataElements1>
{
    #nullable enable
    
    /// <summary>
    /// Message class of the original message.
    /// </summary>
    public MessageClass1Code? MessageClass { get; init; } 
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    public IsoExact2AlphaNumericText? TransactionType { get; init; } 
    /// <summary>
    /// Code identifying the acquirer of the original message.
    /// ISO 8583 bit 32
    /// </summary>
    public IsoMax11NumericText? AcquirerIdentification { get; init; } 
    /// <summary>
    /// Code identifying the sender of the original message.
    /// ISO 8583 bit 33.
    /// </summary>
    public IsoMax11NumericText? SenderIdentification { get; init; } 
    /// <summary>
    /// Local date and time the transaction takes place at the acceptor location.
    /// ISO 8583 bit 12.
    /// </summary>
    public IsoISODateTime? LocalDateTime { get; init; } 
    /// <summary>
    /// Time zone name (for example, as defined by IANA - Internet Assigned Numbers Authority) in the time zone data base.
    /// </summary>
    public IsoMax70Text? TimeZone { get; init; } 
    /// <summary>
    /// Identification of the transaction by the card acceptor. It may appear on the receipt of the cardholder. It remains unchanged throughout the lifetime of the transaction.
    /// </summary>
    public IsoMax35Text? TransactionReference { get; init; } 
    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// ISO 8583 bit 7
    /// </summary>
    public IsoISODateTime? TransmissionDateTime { get; init; } 
    /// <summary>
    /// Transaction reference of the original message.
    ///  ISO 8583 bit 11.
    /// </summary>
    public IsoMax12NumericText? SystemTraceAuditNumber { get; init; } 
    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    public required IsoExact12Text RetrievalReferenceNumber { get; init; } 
    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; } 
    /// <summary>
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    public TransactionLifeCycleIdentification1? LifeCycleTraceIdentificationData { get; init; } 
    /// <summary>
    /// Reason for not providing a lifecycle trace identification information.
    /// </summary>
    public IsoMax70Text? LifeCycleTraceIdentificationMissing { get; init; } 
    /// <summary>
    /// Data supplied by an acquirer in an authorisation or financial request, advice or notification that may be required to be provided in a subsequent transaction.
    /// </summary>
    public IsoMax140Text? AcquirerReferenceData { get; init; } 
    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction (for example, for researching retrievals and chargebacks).
    /// ISO 8583:2003 bit 31
    /// </summary>
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; } 
    /// <summary>
    /// Data supplied by a card issuer in an authorisation response, financial response message or in a chargeback transaction that the acquirer may be required to provide in subsequent transactions.
    /// ISO 8583:1993 and ISO 8583:2003 bit 95.
    /// </summary>
    public IsoMax1000Text? CardIssuerReferenceData { get; init; } 
    
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
        if (MessageClass is MessageClass1Code MessageClassValue)
        {
            writer.WriteStartElement(null, "MsgClss", xmlNamespace );
            writer.WriteValue(MessageClassValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionType is IsoExact2AlphaNumericText TransactionTypeValue)
        {
            writer.WriteStartElement(null, "TxTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact2AlphaNumericText(TransactionTypeValue)); // data type Exact2AlphaNumericText System.String
            writer.WriteEndElement();
        }
        if (AcquirerIdentification is IsoMax11NumericText AcquirerIdentificationValue)
        {
            writer.WriteStartElement(null, "AcqrrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax11NumericText(AcquirerIdentificationValue)); // data type Max11NumericText System.String
            writer.WriteEndElement();
        }
        if (SenderIdentification is IsoMax11NumericText SenderIdentificationValue)
        {
            writer.WriteStartElement(null, "SndrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax11NumericText(SenderIdentificationValue)); // data type Max11NumericText System.String
            writer.WriteEndElement();
        }
        if (LocalDateTime is IsoISODateTime LocalDateTimeValue)
        {
            writer.WriteStartElement(null, "LclDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(LocalDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (TimeZone is IsoMax70Text TimeZoneValue)
        {
            writer.WriteStartElement(null, "TmZone", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(TimeZoneValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (TransactionReference is IsoMax35Text TransactionReferenceValue)
        {
            writer.WriteStartElement(null, "TxRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransmissionDateTime is IsoISODateTime TransmissionDateTimeValue)
        {
            writer.WriteStartElement(null, "TrnsmssnDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(TransmissionDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (SystemTraceAuditNumber is IsoMax12NumericText SystemTraceAuditNumberValue)
        {
            writer.WriteStartElement(null, "SysTracAudtNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax12NumericText(SystemTraceAuditNumberValue)); // data type Max12NumericText System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RtrvlRefNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact12Text(RetrievalReferenceNumber)); // data type Exact12Text System.String
        writer.WriteEndElement();
        if (LifeCycleSupport is LifeCycleSupport1Code LifeCycleSupportValue)
        {
            writer.WriteStartElement(null, "LifeCyclSpprt", xmlNamespace );
            writer.WriteValue(LifeCycleSupportValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (LifeCycleTraceIdentificationData is TransactionLifeCycleIdentification1 LifeCycleTraceIdentificationDataValue)
        {
            writer.WriteStartElement(null, "LifeCyclTracIdData", xmlNamespace );
            LifeCycleTraceIdentificationDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LifeCycleTraceIdentificationMissing is IsoMax70Text LifeCycleTraceIdentificationMissingValue)
        {
            writer.WriteStartElement(null, "LifeCyclTracIdMssng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(LifeCycleTraceIdentificationMissingValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (AcquirerReferenceData is IsoMax140Text AcquirerReferenceDataValue)
        {
            writer.WriteStartElement(null, "AcqrrRefData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(AcquirerReferenceDataValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (AcquirerReferenceNumber is IsoMax23NumericText AcquirerReferenceNumberValue)
        {
            writer.WriteStartElement(null, "AcqrrRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax23NumericText(AcquirerReferenceNumberValue)); // data type Max23NumericText System.String
            writer.WriteEndElement();
        }
        if (CardIssuerReferenceData is IsoMax1000Text CardIssuerReferenceDataValue)
        {
            writer.WriteStartElement(null, "CardIssrRefData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1000Text(CardIssuerReferenceDataValue)); // data type Max1000Text System.String
            writer.WriteEndElement();
        }
    }
    public static OriginalDataElements1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
