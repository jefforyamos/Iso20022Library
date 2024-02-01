﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ISATransfer15.  ISO2002 ID# _Uu-skRwqEeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
public partial record ISATransfer15
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Identification assigned to the transfer of asset, typically assigned by the transferee.
    /// </summary>
    public required IsoMax35Text TransferIdentification { get; init; } 
    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    public ISAPortfolio3Choice_? Portfolio { get; init; } 
    /// <summary>
    /// Indicator that all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    public required IsoYesNoIndicator AllOtherCash { get; init; } 
    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    public FinancialInstrument36[] FinancialInstrumentAssetForTransfer { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
