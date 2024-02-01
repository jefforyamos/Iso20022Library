﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VerificationReport4.  ISO2002 ID# _d114MdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the verification of identification data for which verification was requested.
/// </summary>
public partial record VerificationReport4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the original message.
    /// </summary>
    public required IsoMax35Text OriginalIdentification { get; init; } 
    /// <summary>
    /// Identifies whether the party and/or account information received is correct.
    /// </summary>
    public required IsoIdentificationVerificationIndicator Verification { get; init; } 
    /// <summary>
    /// Specifies the reason why the verified identification information is incorrect.
    /// </summary>
    public VerificationReason1Choice_? Reason { get; init; } 
    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    public IdentificationInformation4? OriginalPartyAndAccountIdentification { get; init; } 
    /// <summary>
    /// Provides party and/or account identification information.
    /// </summary>
    public IdentificationInformation4? UpdatedPartyAndAccountIdentification { get; init; } 
    
    #nullable disable
}
