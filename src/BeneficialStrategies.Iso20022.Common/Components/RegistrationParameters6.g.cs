﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegistrationParameters6.  ISO2002 ID# _Ly6D8bPwEeelzbgsFa3sqQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to registration of securities.
/// </summary>
public partial record RegistrationParameters6
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a deposit.
    /// </summary>
    public IsoMax35Text? CertificationIdentification { get; init; } 
    /// <summary>
    /// Date/time at which the certificates in the deposit were validated by the agent.
    /// </summary>
    public IDateAndDateTime2Choice? CertificationDateTime { get; init; } 
    /// <summary>
    /// Account at the registrar where financial instruments are registered.
    /// </summary>
    public IsoMax35Text? RegistrarAccount { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    public SecuritiesCertificate4? CertificateNumber { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
