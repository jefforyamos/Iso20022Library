﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PortfolioTransfer3.  ISO2002 ID# _P8vOUUyGEeir2sRRVd9XhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of product and assets to be transferred.
/// </summary>
public partial record PortfolioTransfer3
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
    /// Date for which the instructing party requests the transfer of the portfolio as a whole.
    /// </summary>
    public IsoISODate? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    public FundPortfolio3Choice_? Portfolio { get; init; } 
    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash. 
    /// </summary>
    public AllOtherCash1Code? AllOtherCash { get; init; } 
    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    public CashAll1Code? CashAll { get; init; } 
    /// <summary>
    /// Specifies what must be done with cash in the account that is awaiting investment.
    /// </summary>
    public ResidualCash1Code? ResidualCash { get; init; } 
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    public PaymentInstrument14? PaymentDetails { get; init; } 
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    public FinancialInstrument69[] FinancialInstrumentAssetForTransfer { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    public AdditionalInformation15[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
