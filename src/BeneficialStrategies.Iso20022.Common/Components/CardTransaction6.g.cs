﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransaction6.  ISO2002 ID# _YXjg8YK5EeSqNu7AiKfyqQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction for which the financial authorisation has been requested.
/// </summary>
public partial record CardTransaction6
     : IIsoXmlSerilizable<CardTransaction6>
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction being undertaken for the main service. 
    /// It correspond partially to the ISO 8583, field number 3.
    /// </summary>
    public required CardPaymentServiceType7Code TransactionType { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    public TransactionIdentifier2? Reconciliation { get; init; } 
    /// <summary>
    /// Date and time of the transaction transported unchanged by the acquirer from the card acceptor to the issuer. Corresponds to the CAPE data element TransactionIdentification/ TransactionDateTime.
    /// It correspond to the ISO 8583, field number 12.
    /// </summary>
    public required IsoISODateTime AcceptorTransactionDateTime { get; init; } 
    /// <summary>
    /// Number generated by the transaction Initiator to assist in identifying a transaction uniquely. This value remains unchanged for all messages within a message pair exchange, for instance an initiation/response. It corresponds to the ISO 8583 field number 11.
    /// </summary>
    public required IsoMax35Text InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification to match transactions throughout their life cycle (for example, authorisation to financial presentment, financial presentment to chargeback). It shall contain the same value in all messages throughout a transaction’s life cycle. It corresponds partially to ISO 8583: 2003 field number 21.
    /// </summary>
    public IsoMax35Text? TransactionLifeCycleIdentification { get; init; } 
    /// <summary>
    /// Life cycle transaction sequence number when multiple authorisations are performed for the same presentment.
    /// It corresponds partially to ISO 8583: 2003, field number 21.
    /// </summary>
    public IsoNumber? TransactionLifeCycleSequenceNumber { get; init; } 
    /// <summary>
    /// Total number of transactions under the same life cycle transaction sequence number.
    /// </summary>
    public IsoNumber? TransactionLifeCycleSequenceCounter { get; init; } 
    /// <summary>
    /// Data supplied by a card issuer in response messages or in issuer generated messages, that the acquirer may be required to be provided in subsequent messages. It corresponds to ISO 8583: 93 and 2003 field number 95.
    /// </summary>
    public IsoMax140Text? CardIssuerReferenceData { get; init; } 
    /// <summary>
    /// Details of the card transaction.
    /// </summary>
    public required CardTransactionDetail4 TransactionDetails { get; init; } 
    /// <summary>
    /// Outcome of the authorisation.
    /// </summary>
    public AuthorisationResult8? AuthorisationResult { get; init; } 
    
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
        writer.WriteStartElement(null, "TxTp", xmlNamespace );
        writer.WriteValue(TransactionType.ToString()); // Enum value
        writer.WriteEndElement();
        if (Reconciliation is TransactionIdentifier2 ReconciliationValue)
        {
            writer.WriteStartElement(null, "Rcncltn", xmlNamespace );
            ReconciliationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AccptrTxDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(AcceptorTransactionDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InitrTxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(InitiatorTransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (TransactionLifeCycleIdentification is IsoMax35Text TransactionLifeCycleIdentificationValue)
        {
            writer.WriteStartElement(null, "TxLifeCyclId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionLifeCycleIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransactionLifeCycleSequenceNumber is IsoNumber TransactionLifeCycleSequenceNumberValue)
        {
            writer.WriteStartElement(null, "TxLifeCyclSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(TransactionLifeCycleSequenceNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (TransactionLifeCycleSequenceCounter is IsoNumber TransactionLifeCycleSequenceCounterValue)
        {
            writer.WriteStartElement(null, "TxLifeCyclSeqCntr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(TransactionLifeCycleSequenceCounterValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (CardIssuerReferenceData is IsoMax140Text CardIssuerReferenceDataValue)
        {
            writer.WriteStartElement(null, "CardIssrRefData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(CardIssuerReferenceDataValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxDtls", xmlNamespace );
        TransactionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AuthorisationResult is AuthorisationResult8 AuthorisationResultValue)
        {
            writer.WriteStartElement(null, "AuthstnRslt", xmlNamespace );
            AuthorisationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardTransaction6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
