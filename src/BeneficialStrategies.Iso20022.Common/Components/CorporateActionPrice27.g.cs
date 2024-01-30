﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice27.  ISO2002 ID# _9EcCofo1EeCqjOT-vUu2sQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices.
/// </summary>
public partial record CorporateActionPrice27
{
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public IPriceFormat5Choice? CashInLieuOfSharePrice { get; init; } 
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    public IIndicativeOrMarketPrice2Choice? IndicativeOrMarketPrice { get; init; } 
    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    public AmountPrice2? CashValueForTax { get; init; } 
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    public IPriceFormat6Choice? GenericCashPricePaidPerProduct { get; init; } 
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    public IPriceFormat7Choice? GenericCashPriceReceivedPerProduct { get; init; } 
    
    #nullable disable
}
