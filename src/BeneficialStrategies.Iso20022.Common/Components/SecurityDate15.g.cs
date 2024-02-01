﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityDate15.  ISO2002 ID# _dCdOg7QXEeeKRKrD60ELBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security date details.
/// </summary>
public partial record SecurityDate15
{
    #nullable enable
    
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    public required DateAndDateTime2Choice_ PostingDate { get; init; } 
    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    public DateFormat43Choice_? AvailableDate { get; init; } 
    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    public DateFormat43Choice_? PariPassuDate { get; init; } 
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    public DateFormat43Choice_? DividendRankingDate { get; init; } 
    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public DateFormat43Choice_? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    public DateFormat43Choice_? PaymentDate { get; init; } 
    
    #nullable disable
}
