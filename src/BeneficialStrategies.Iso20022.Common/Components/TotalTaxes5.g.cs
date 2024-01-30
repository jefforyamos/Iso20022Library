﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalTaxes5.  ISO2002 ID# _WKLBTNp-Ed-ak6NoX_4Aeg_-1710794276.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information regarding the total amount of taxes.
/// </summary>
public partial record TotalTaxes5
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 
    /// <summary>
    /// Information related to a specific tax.
    /// </summary>
    // public IReadOnlyCollection<Tax20> TaxDetails { get; init; }
    
    #nullable disable
}
