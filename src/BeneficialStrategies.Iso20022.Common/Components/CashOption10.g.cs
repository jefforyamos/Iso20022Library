﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption10.  ISO2002 ID# _Ju3igeGiEd-1Ktb5rVaajw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
public partial record CashOption10
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification20? IncomeType { get; init; } 
    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; } 
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    public CorporateActionAmounts10? AmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    public required CorporateActionDate17 DateDetails { get; init; } 
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
    public PriceDetails3? PriceDetails { get; init; } 
    
    #nullable disable
}
