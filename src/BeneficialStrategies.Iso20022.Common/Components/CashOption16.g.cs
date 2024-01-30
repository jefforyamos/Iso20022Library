﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption16.  ISO2002 ID# _FVhZ8fo0EeCfbIXrKCjG0g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
public partial record CashOption16
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    public Payment1Code? ContractualPaymentIndicator { get; init; } 
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    public INonEligibleProceedsIndicator1Choice? NonEligibleProceedsIndicator { get; init; } 
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    public IssuerTaxability1Code? IssuerOfferorTaxabilityIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification20? IncomeType { get; init; } 
    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    public ICashAccountIdentification5Choice? CashAccountIdentification { get; init; } 
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    public CorporateActionAmounts16? AmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    public required CorporateActionDate23 DateDetails { get; init; } 
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    public ForeignExchangeTerms13? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    public RateDetails3? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public PriceDetails6? PriceDetails { get; init; } 
    
    #nullable disable
}
