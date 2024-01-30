﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardholderAuthentication13.  ISO2002 ID# _-PhO4QxuEeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the authentication of the cardholder.
/// </summary>
public partial record CardholderAuthentication13
{
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; } 
    /// <summary>
    /// If Strong Customer Authentication is not mandated to process the transaction, this message element must identify the reason of exemption.
    /// </summary>
    public Exemption1Code? AuthenticationExemption { get; init; } 
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    public ContentInformationType22? ProtectedAuthenticationValue { get; init; } 
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    public OnLinePIN7? CardholderOnLinePIN { get; init; } 
    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    public PersonIdentification15? CardholderIdentification { get; init; } 
    /// <summary>
    /// Numeric characters of the cardholder's billing or shipping address for verification.
    /// </summary>
    public AddressVerification1? AddressVerification { get; init; } 
    /// <summary>
    /// Type of authentication for a given method - e.g. three-domain authentication, scheme-proprietary authentication, etc.
    /// </summary>
    public IsoMax35Text? AuthenticationType { get; init; } 
    /// <summary>
    /// Level of authentication for a given type – e.g. value assigned by scheme rules or by bilateral agreements.
    /// </summary>
    public IsoMax35Text? AuthenticationLevel { get; init; } 
    /// <summary>
    /// Result of authentication.
    /// </summary>
    public AuthenticationResult1Code? AuthenticationResult { get; init; } 
    /// <summary>
    /// Additional information related to the result of the authentication.
    /// </summary>
    public ExternallyDefinedData1? AuthenticationAdditionalInformation { get; init; } 
    
    #nullable disable
}
