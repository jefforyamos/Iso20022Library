﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardholderAuthentication6.  ISO2002 ID# _HE--UWjNEeSHBr6v3XO0Mg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the authentication of the cardholder.
/// </summary>
[DataContract]
[XmlType]
public partial record CardholderAuthentication6
{
    #nullable enable
    
    /// <summary>
    /// Method to authenticate the cardholder.
    /// </summary>
    [DataMember]
    public required AuthenticationMethod3Code AuthenticationMethod { get; init; } 
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [DataMember]
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [DataMember]
    public ContentInformationType10? ProtectedAuthenticationValue { get; init; } 
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [DataMember]
    public OnLinePIN4? CardholderOnLinePIN { get; init; } 
    /// <summary>
    /// Numeric characters of the cardholder's billing or shipping address for verification.
    /// </summary>
    [DataMember]
    public AddressVerification1? AddressVerification { get; init; } 
    
    #nullable disable
}
