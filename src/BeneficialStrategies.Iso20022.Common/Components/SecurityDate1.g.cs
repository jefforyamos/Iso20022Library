﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityDate1.  ISO2002 ID# _TV3toNp-Ed-ak6NoX_4Aeg_-259263507.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security date details.
/// </summary>
public partial record SecurityDate1
{
    #nullable enable
    
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    public required IDateAndDateTimeChoice PostingDate { get; init; } 
    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    public IDateFormat6Choice? AvailableDate { get; init; } 
    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    public IDateFormat6Choice? PariPassuDate { get; init; } 
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    public IDateFormat6Choice? DividendRankingDate { get; init; } 
    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public IDateFormat6Choice? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    public IDateFormat6Choice? PaymentDate { get; init; } 
    
    #nullable disable
}
