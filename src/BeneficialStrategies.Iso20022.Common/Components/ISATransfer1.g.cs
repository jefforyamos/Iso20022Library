﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ISATransfer1.  ISO2002 ID# _Ku_xgfpfEeCLMa5EIHtDrg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
public partial record ISATransfer1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Identification assigned by the new plan manager to each transfer of asset.
    /// </summary>
    public required IsoMax35Text TransferIdentification { get; init; } 
    /// <summary>
    /// Requested date at which the assets should be transferred.
    /// </summary>
    public IDateFormat1Choice? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    public required IISAPortfolio1Choice Portfolio { get; init; } 
    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    public ResidualCash1Code? ResidualCash { get; init; } 
    /// <summary>
    /// Indicator that all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    public required IsoYesNoIndicator AllOtherCash { get; init; } 
    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    public FinancialInstrument23? FinancialInstrumentAssetForTransfer { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
