﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardManagementResponse2.  ISO2002 ID# _mb2JwYN1EeuHqfO1LgkE9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the card management response message.
/// </summary>
public partial record CardManagementResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required Environment25 Environment { get; init; } 
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    public required Context13 Context { get; init; } 
    /// <summary>
    /// Response to a card management Initiation transaction.
    /// </summary>
    public required Transaction153 Transaction { get; init; } 
    /// <summary>
    /// Outcome of the processing of the transaction.
    /// </summary>
    public required ProcessingResult9 ProcessingResult { get; init; } 
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
