﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount157.  ISO2002 ID# _-ZuPpYftEeevKP8c-ilVhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party and references.
/// </summary>
public partial record PartyIdentificationAndAccount157
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required PartyIdentification113 PartyIdentification { get; init; } 
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    public IsoMax35Text? ProcessingReference { get; init; } 
    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    public IDateAndDateTime2Choice? ProcessingDate { get; init; } 
    
    #nullable disable
}
