﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionLifeCycleIdentification1.  ISO2002 ID# _5kV_sER7Eeeb1MmUPTrSMw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique global identification structure used to match transactions throughout their lifecycle (for example, authorisation to financial, financial to chargebacks, etc.). 
/// It shall contain the same value in all messages throughout a transaction's lifecycle.
/// ISO 8583:2003 bit 21
/// </summary>
[DataContract]
[XmlType]
public partial record TransactionLifeCycleIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier.
    /// ISO 8583:2003 bit 21-2
    /// </summary>
    [DataMember]
    public required IsoExact15Text Identification { get; init; } 
    /// <summary>
    /// Contains authorisation sequence number.
    /// </summary>
    [DataMember]
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; } 
    /// <summary>
    /// Number used with trace identifier to uniquely identify where a single authorisation was obtained covering a number of financial presentments.
    /// ISO 8583:2003 bit 21-3
    /// </summary>
    [DataMember]
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; } 
    /// <summary>
    /// Expected maximum number of presentments for this transaction.
    /// </summary>
    [DataMember]
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; } 
    /// <summary>
    /// Code calculated using an algorithm against key transaction data elements that are common to both authorisation and financial messages.
    /// ISO 8583:2003 bit 21-4
    /// </summary>
    [DataMember]
    public IsoMax35Text? AuthenticationToken { get; init; } 
    
    #nullable disable
}
