﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthorisationInitiation2.  ISO2002 ID# _KnK6MYEKEeu6D49Gi-ZPwQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the authorisation initiation message.
/// </summary>
public partial record AuthorisationInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Contains or describes the information pertaining to the actors interacting with the transaction.
    /// </summary>
    public required Environment17 Environment { get; init; } 
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    public required Context10 Context { get; init; } 
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    public required Transaction142 Transaction { get; init; } 
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    public AddendumData3? AddendumData { get; init; } 
    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    public ProcessingResult16? ProcessingResult { get; init; } 
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    public ProtectedData1? ProtectedData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
