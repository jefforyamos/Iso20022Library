﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardholderAuthentication8.  ISO2002 ID# _UV3EwYoaEeSirOZJBRz_nA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the authentication of the card and the cardholder.
/// </summary>
public partial record CardholderAuthentication8
{
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the customer or its card.
    /// </summary>
    public required AuthenticationMethod7Code AuthenticationMethod { get; init; } 
    /// <summary>
    /// True if an authentication token is requested to the host. This token will be provided to the ATM for further authentication.
    /// </summary>
    public IsoTrueFalseIndicator? TokenRequested { get; init; } 
    /// <summary>
    /// Value or token to be used for customer or card authentication.
    /// </summary>
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    public ContentInformationType10? ProtectedAuthenticationValue { get; init; } 
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    public OnLinePIN5? CardholderOnLinePIN { get; init; } 
    
    #nullable disable
}
