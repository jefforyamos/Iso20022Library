﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceInformation3.  ISO2002 ID# _Qf60NNp-Ed-ak6NoX_4Aeg_-1826849881.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
public partial record PriceInformation3
{
    #nullable enable
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    public required IPriceRateOrAmountOrUnknownChoice Value { get; init; } 
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    public required IUnitPriceType1Choice PriceType { get; init; } 
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    public IPriceSourceFormatChoice? SourceOfPrice { get; init; } 
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    public IDateAndDateTimeChoice? QuotationDate { get; init; } 
    /// <summary>
    /// Indicates whether the price is expressed as a yield. The absence of Yielded means it is not applicable.
    /// </summary>
    public IsoYesNoIndicator? YieldedIndicator { get; init; } 
    
    #nullable disable
}
