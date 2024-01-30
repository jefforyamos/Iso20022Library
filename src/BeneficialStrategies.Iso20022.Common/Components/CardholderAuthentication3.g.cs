﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardholderAuthentication3.  ISO2002 ID# _Fw2qQQvUEeKzJ69IWwzB9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the authentication of the cardholder.
/// </summary>
public partial record CardholderAuthentication3
{
    #nullable enable
    
    /// <summary>
    /// Method used to authenticate a cardholder.
    /// </summary>
    public required AuthenticationMethod2Code AuthenticationMethod { get; init; } 
    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// </summary>
    public AuthenticationEntity1Code? AuthenticationEntity { get; init; } 
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    public IsoMax40Text? AuthenticationValue { get; init; } 
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    public OnLinePIN2? CardholderOnLinePIN { get; init; } 
    /// <summary>
    /// Identifies in electronic commerce transactions whether customer authentication is supported and data is available.
    /// </summary>
    public IsoMax35Text? AuthenticationCollectionIndicator { get; init; } 
    
    #nullable disable
}
