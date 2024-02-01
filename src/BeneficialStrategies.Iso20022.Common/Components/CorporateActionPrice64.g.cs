﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice64.  ISO2002 ID# _ckC_d5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices.
/// </summary>
public partial record CorporateActionPrice64
{
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat52Choice_? CashInLieuOfSharePrice { get; init; } 
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    public IndicativeOrMarketPrice9Choice_? IndicativeOrMarketPrice { get; init; } 
    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    public AmountPrice4? CashValueForTax { get; init; } 
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    public PriceFormat55Choice_? GenericCashPricePaidPerProduct { get; init; } 
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    public PriceFormat56Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    
    #nullable disable
}
