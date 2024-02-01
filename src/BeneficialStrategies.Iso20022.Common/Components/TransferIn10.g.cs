﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferIn10.  ISO2002 ID# _QKPiIRYAEeOBE-jZfcm4KQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer in transaction.
/// </summary>
public partial record TransferIn10
{
    #nullable enable
    
    /// <summary>
    /// Requested date at which the instructing party places the transfer instruction.
    /// </summary>
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Details of the transfer and cancellation.
    /// </summary>
    public TransferIn11[] TransferAndReferences { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    public required InvestmentAccount40 AccountDetails { get; init; } 
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    public DeliverInformation13? SettlementDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1[] Extension { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
