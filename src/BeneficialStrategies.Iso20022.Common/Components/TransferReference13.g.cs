﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferReference13.  ISO2002 ID# _YTDBIYi2EeefvMoXmllHqg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of a transfer and of a transfer cancellation.
/// </summary>
public partial record TransferReference13
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the portfolio transfer instruction, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the portfolio transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference8? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the portfolio transfer allocated by the counterparty.
    /// </summary>
    public AdditionalReference8? CounterpartyReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the portfolio transfer execution, as assigned by the confirming party.
    /// </summary>
    public IsoMax35Text? TransferConfirmationReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the portfolio transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Reason for the cancellation.
    /// </summary>
    public IsoMax35Text? CancellationReason { get; init; } 
    
    #nullable disable
}
