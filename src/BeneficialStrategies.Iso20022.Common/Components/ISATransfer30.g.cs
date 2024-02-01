﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ISATransfer30.  ISO2002 ID# _FBued4fuEeevKP8c-ilVhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of product and assets to be transferred.
/// </summary>
public partial record ISATransfer30
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    public required IsoMax35Text TransferIdentification { get; init; } 
    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    public IsoMax35Text? TransferConfirmationIdentification { get; init; } 
    /// <summary>
    /// Specifies what must be done with cash in the account that is awaiting investment.
    /// </summary>
    public ResidualCash1Code? ResidualCash { get; init; } 
    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    public ISAPortfolio1Choice_? Portfolio { get; init; } 
    /// <summary>
    /// Specifies whether all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    public AllOtherCash1Code? AllOtherCash { get; init; } 
    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    public FinancialInstrument61[] FinancialInstrumentAssetForTransfer { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
