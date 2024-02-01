﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxVoucher4.  ISO2002 ID# _7HbzEbQZEeeKRKrD60ELBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies tax vouchers in the framework of a corporate action event.
/// </summary>
public partial record TaxVoucher4
{
    #nullable enable
    
    /// <summary>
    /// Unique reference for the tax voucher required by the relevant tax authorities to ensure that any claim relating to this particular tax voucher cannot be duplicated.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Date on which a dividend reinvestment purchase was completed. If there is only one bargain involved, the time it was struck needs to be included.
    /// </summary>
    public DateAndDateTime2Choice_? BargainDate { get; init; } 
    /// <summary>
    /// Settlement date of the dividend reinvestment purchase transaction.
    /// </summary>
    public DateAndDateTime2Choice_? BargainSettlementDate { get; init; } 
    
    #nullable disable
}
