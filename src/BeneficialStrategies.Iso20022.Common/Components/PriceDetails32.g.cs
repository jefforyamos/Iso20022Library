﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceDetails32.  ISO2002 ID# _xzD5MTQQEe2o-K1dwNg8Gg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the prices related to a corporate action option.
/// </summary>
[DataContract]
[XmlType]
public partial record PriceDetails32
{
    #nullable enable
    
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    [DataMember]
    public PriceFormat51Choice_? GenericCashPricePaidPerProduct { get; init; } 
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [DataMember]
    public PriceFormat64Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [DataMember]
    public PriceFormat50Choice_? CashInLieuOfSharePrice { get; init; } 
    
    #nullable disable
}
