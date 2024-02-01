﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PortfolioTransfer6.  ISO2002 ID# _mrKwu5NBEemQB_8XA98K0Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of product and assets to be transferred.
/// </summary>
public partial record PortfolioTransfer6
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
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    public FundPortfolio4Choice_? Portfolio { get; init; } 
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    public FinancialInstrument84[] FinancialInstrumentAssetForTransfer { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    public AdditionalInformation15[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
