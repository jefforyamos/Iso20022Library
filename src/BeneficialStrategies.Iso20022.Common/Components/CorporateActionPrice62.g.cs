﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice62.  ISO2002 ID# _chezrZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionPrice62
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [DataMember]
    public IndicativeOrMarketPrice9Choice_? IndicativeOrMarketPrice { get; init; } 
    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    [DataMember]
    public PriceFormat52Choice_? IssuePrice { get; init; } 
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [DataMember]
    public PriceFormat53Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [DataMember]
    public PriceFormat52Choice_? GenericCashPricePaidPerProduct { get; init; } 
    
    #nullable disable
}
