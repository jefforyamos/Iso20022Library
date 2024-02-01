﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferIn5.  ISO2002 ID# _Tcg_Mfr3EeCJc7cZxzE2fg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer in transaction.
/// </summary>
public partial record TransferIn5
{
    #nullable enable
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    public Transfer16[] TransferDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    public required InvestmentAccount22 AccountDetails { get; init; } 
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    public required DeliverInformation8 SettlementDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1[] Extension { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
