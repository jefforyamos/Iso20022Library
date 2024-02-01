﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceInformation5.  ISO2002 ID# _QebmdNp-Ed-ak6NoX_4Aeg_-1444606274.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
public partial record PriceInformation5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    public required TypeOfPrice4Choice_ Type { get; init; } 
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    public required PriceRateOrAmountOrUnknownChoice_ Value { get; init; } 
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    public required YieldedOrValueType1Choice_ ValueType { get; init; } 
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    public MarketIdentification6? SourceOfPrice { get; init; } 
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    public DateAndDateTimeChoice_? QuotationDate { get; init; } 
    
    #nullable disable
}
