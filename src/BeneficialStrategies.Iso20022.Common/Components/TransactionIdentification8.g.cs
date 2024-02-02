﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionIdentification8.  ISO2002 ID# _lUmiMER2Eeeb1MmUPTrSMw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the transaction
/// </summary>
[DataContract]
[XmlType]
public partial record TransactionIdentification8
{
    #nullable enable
    
    /// <summary>
    /// Local date and time the transaction takes place at the card acceptor location.
    /// ISO 8583:87 bit 12 and 13, ISO 8583:93/2003 bit 12
    /// </summary>
    [DataMember]
    public required IsoISODateTime LocalDateTime { get; init; } 
    /// <summary>
    /// Time zone name (for example, as defined by IANA - Internet Assigned Numbers Authority - in the time zone database).
    /// </summary>
    [DataMember]
    public IsoMax70Text? TimeZone { get; init; } 
    /// <summary>
    /// Identification of the transaction by the card acceptor. It may appear on the receipt of the cardholder. It remains unchanged throughout the lifetime of the transaction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? TransactionReference { get; init; } 
    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// ISO 8583 bit 7
    /// </summary>
    [DataMember]
    public IsoISODateTime? TransmissionDateTime { get; init; } 
    /// <summary>
    /// Number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange (for example, request/repeat and response).
    /// ISO 8583 bit 11.
    /// </summary>
    [DataMember]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; } 
    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    [DataMember]
    public required IsoExact12Text RetrievalReferenceNumber { get; init; } 
    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    [DataMember]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; } 
    /// <summary>
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    [DataMember]
    public TransactionLifeCycleIdentification1? LifeCycleTraceIdentificationData { get; init; } 
    /// <summary>
    /// Reason for not providing a lifecycle trace identification information.
    /// </summary>
    [DataMember]
    public IsoMax70Text? LifeCycleTraceIdentificationMissing { get; init; } 
    /// <summary>
    /// Data supplied by an acquirer in an authorisation or financial request, advice or notification that may be required to be provided in a subsequent transaction.
    /// ISO 8583:93 bit 31
    /// </summary>
    [DataMember]
    public IsoMax140Text? AcquirerReferenceData { get; init; } 
    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction (for example, for researching retrievals and chargebacks).
    /// ISO 8583:2003 bit 31
    /// </summary>
    [DataMember]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; } 
    /// <summary>
    /// Data supplied by a card issuer in an authorisation response, financial response message or in a chargeback transaction that the acquirer may be required to provide in subsequent transactions.
    /// ISO 8583:1993 and ISO 8583:2003 bit 95.
    /// </summary>
    [DataMember]
    public IsoMax1000Text? CardIssuerReferenceData { get; init; } 
    /// <summary>
    /// Data elements contained in the original message.
    /// ISO 8583:1987 bit 90 and ISO 8583:1993/2003 bit 56
    /// </summary>
    [DataMember]
    public OriginalDataElements1? OriginalDataElements { get; init; } 
    
    #nullable disable
}
