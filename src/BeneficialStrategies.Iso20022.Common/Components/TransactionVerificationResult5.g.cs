﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionVerificationResult5.  ISO2002 ID# _9soGsYocEeSirOZJBRz_nA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of performed verifications for the transaction.
/// </summary>
public partial record TransactionVerificationResult5
{
    #nullable enable
    
    /// <summary>
    /// Method of verification that has been performed.
    /// </summary>
    public required AuthenticationMethod7Code Method { get; init; } 
    /// <summary>
    /// Entity or device that has performed the verification.
    /// </summary>
    public AuthenticationEntity2Code? VerificationEntity { get; init; } 
    /// <summary>
    /// Result of the verification.
    /// </summary>
    public Verification1Code? Result { get; init; } 
    /// <summary>
    /// Additional result of the verification.
    /// </summary>
    public IsoMax500Text? AdditionalResult { get; init; } 
    /// <summary>
    /// Token provided to the ATM for further proof of authentication.
    /// </summary>
    public IsoMax140Binary? AuthenticationToken { get; init; } 
    
    #nullable disable
}
