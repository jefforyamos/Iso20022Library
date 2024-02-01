﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount130.  ISO2002 ID# _ckJtX5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification and account of the party.
/// </summary>
public partial record PartyIdentificationAndAccount130
{
    #nullable enable
    
    /// <summary>
    /// Identification of a party.
    /// </summary>
    public required PartyIdentification113Choice_ Identification { get; init; } 
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    public CashAccountIdentification6Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
    
    #nullable disable
}
