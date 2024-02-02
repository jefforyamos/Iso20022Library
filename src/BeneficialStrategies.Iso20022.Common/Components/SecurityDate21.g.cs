﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityDate21.  ISO2002 ID# _VTskzTQKEe2o-K1dwNg8Gg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security date details.
/// </summary>
[DataContract]
[XmlType]
public partial record SecurityDate21
{
    #nullable enable
    
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [DataMember]
    public required IsoISODate PostingDate { get; init; } 
    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    [DataMember]
    public DateFormat30Choice_? AvailableDate { get; init; } 
    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [DataMember]
    public DateFormat30Choice_? PariPassuDate { get; init; } 
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [DataMember]
    public DateFormat30Choice_? DividendRankingDate { get; init; } 
    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [DataMember]
    public DateFormat30Choice_? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [DataMember]
    public DateFormat30Choice_? PaymentDate { get; init; } 
    
    #nullable disable
}
