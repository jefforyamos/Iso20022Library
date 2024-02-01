﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancellationStatusAndReason4.  ISO2002 ID# _D9JcH4fuEeevKP8c-ilVhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a transfer cancellation instruction and reason for the status.
/// </summary>
public partial record CancellationStatusAndReason4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference7? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Status of the transfer cancellation.
    /// </summary>
    public required Status21Choice_ Status { get; init; } 
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    public PartyIdentification113? StatusInitiator { get; init; } 
    
    #nullable disable
}
