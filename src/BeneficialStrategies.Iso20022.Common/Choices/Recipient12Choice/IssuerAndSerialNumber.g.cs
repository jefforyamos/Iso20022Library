﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IssuerAndSerialNumber.  ISO2002 ID# _TNT_oVFKEeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient12Choice;

/// <summary>
/// Certificate issuer name and serial number (see ITU X.509).
/// </summary>
public partial record IssuerAndSerialNumber : IRecipient12Choice
{
    #nullable enable
    /// <summary>
    /// Certificate issuer name (see X.509).
    /// </summary>
    public required CertificateIssuer1 Issuer { get; init; } 
    /// <summary>
    /// Certificate serial number (see X.509).
    /// </summary>
    public required IsoMax500Binary SerialNumber { get; init; } 
    #nullable disable
}
