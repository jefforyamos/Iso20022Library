﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProxyAppointmentInformation1.  ISO2002 ID# _T44UEdp-Ed-ak6NoX_4Aeg_-1448448855.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates how to register a proxy.
/// </summary>
public partial record ProxyAppointmentInformation1
{
    #nullable enable
    
    /// <summary>
    /// Indicates how to register a proxy.
    /// </summary>
    public IsoMax350Text? RegistrationMethod { get; init; } 
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the intermediary.
    /// </summary>
    public DateFormat2Choice_? Deadline { get; init; } 
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the intermediary (STP mode).
    /// </summary>
    public DateFormat2Choice_? STPDeadline { get; init; } 
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the issuer.
    /// </summary>
    public DateFormat2Choice_? MarketDeadline { get; init; } 
    /// <summary>
    /// Specifies the proxy persons which are authorised by the issuer.
    /// </summary>
    public Proxy1[] AuthorisedProxy { get; init; } = [];
    
    #nullable disable
}
