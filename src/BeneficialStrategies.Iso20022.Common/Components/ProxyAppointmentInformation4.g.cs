﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProxyAppointmentInformation4.  ISO2002 ID# _kQJ7Ja09EemDtrWpq90Ckg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the registration of a proxy.
/// </summary>
public partial record ProxyAppointmentInformation4
{
    #nullable enable
    
    /// <summary>
    /// Specifies how to register the proxy.
    /// </summary>
    public IsoMax350Text? RegistrationMethod { get; init; } 
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the intermediary.
    /// </summary>
    public IDateFormat58Choice? Deadline { get; init; } 
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the issuer.
    /// </summary>
    public IDateFormat58Choice? MarketDeadline { get; init; } 
    /// <summary>
    /// Proxy person that is authorised by the issuer.
    /// </summary>
    public IReadOnlyCollection<Proxy8> AuthorisedProxy { get; init; } = [];
    
    #nullable disable
}
