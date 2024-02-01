﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VerificationInitiation2.  ISO2002 ID# _9_sxcYELEeu6D49Gi-ZPwQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the verification initiation message.
/// </summary>
public partial record VerificationInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required Environment31 Environment { get; init; } 
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    public required Context11 Context { get; init; } 
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    public required Transaction146 Transaction { get; init; } 
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages
    /// </summary>
    public AddendumData5? AddendumData { get; init; } 
    /// <summary>
    /// Outcome of the processing of the verification.
    /// </summary>
    public ProcessingResult12? ProcessingResult { get; init; } 
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    public ProtectedData1[] ProtectedData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
