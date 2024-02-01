﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ISATransfer16.  ISO2002 ID# _prhMYRw0EeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
public partial record ISATransfer16
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
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    public IsoMax35Text? TransferConfirmationIdentification { get; init; } 
    /// <summary>
    /// Requested date at which the assets should be transferred.
    /// </summary>
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    public ISAPortfolio1Choice_? Portfolio { get; init; } 
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
    public FinancialInstrument34[] FinancialInstrumentAssetForTransfer { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
