﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VerificationInitiation1.  ISO2002 ID# _TVdDwVf4EeedJb6VxsnkPg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the verification initiation message.
/// </summary>
[DataContract]
[XmlType]
public partial record VerificationInitiation1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required Environment1 Environment { get; init; } 
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [DataMember]
    public required Context5 Context { get; init; } 
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [DataMember]
    public required Transaction83 Transaction { get; init; } 
    /// <summary>
    /// Outcome of the processing of the verification.
    /// </summary>
    [DataMember]
    public ProcessingResult6? ProcessingResult { get; init; } 
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [DataMember]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [DataMember]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
