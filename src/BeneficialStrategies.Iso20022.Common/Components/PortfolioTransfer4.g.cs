﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PortfolioTransfer4.  ISO2002 ID# _13HFwU3kEeiQHa-q1Uephw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of product and assets to be transferred.
/// </summary>
public partial record PortfolioTransfer4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    public required IsoMax35Text TransferInstructionReference { get; init; } 
    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    public required IsoMax35Text TransferConfirmationIdentification { get; init; } 
    /// <summary>
    /// Date the portfolio transfer instruction was executed.
    /// </summary>
    public IsoISODate? ActualTransferDate { get; init; } 
    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    public IFundPortfolio2Choice? Portfolio { get; init; } 
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
    /// Tax date applicable to all the assets.
    /// </summary>
    public IsoISODate? TaxDate { get; init; } 
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    public PaymentInstrument14? PaymentDetails { get; init; } 
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    public FinancialInstrument70? FinancialInstrumentAssetForTransfer { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
