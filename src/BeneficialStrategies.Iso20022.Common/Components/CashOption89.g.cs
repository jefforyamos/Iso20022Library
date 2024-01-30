﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption89.  ISO2002 ID# _Wfijml99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
public partial record CashOption89
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    public IAccount9Choice? Account { get; init; } 
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    public required IsoISODate PostingDate { get; init; } 
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    public IsoISODate? OriginalPostingDate { get; init; } 
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; } 
    
    #nullable disable
}
