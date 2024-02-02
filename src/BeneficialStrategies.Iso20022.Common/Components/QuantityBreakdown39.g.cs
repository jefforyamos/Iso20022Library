﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityBreakdown39.  ISO2002 ID# _5W4BE5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
[DataContract]
[XmlType]
public partial record QuantityBreakdown39
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [DataMember]
    public GenericIdentification39? LotNumber { get; init; } 
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [DataMember]
    public Balance11? LotQuantity { get; init; } 
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? LotDateTime { get; init; } 
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [DataMember]
    public Price3? LotPrice { get; init; } 
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [DataMember]
    public TypeOfPrice32Choice_? TypeOfPrice { get; init; } 
    /// <summary>
    /// Valuation amounts for the lot provided in the base currency of the account.
    /// </summary>
    [DataMember]
    public BalanceAmounts6? AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts for the lot provided in the currency of the financial instrument.
    /// </summary>
    [DataMember]
    public BalanceAmounts6? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts for the lot provided in another currency than the base currency of the account.
    /// </summary>
    [DataMember]
    public BalanceAmounts6? AlternateReportingCurrencyAmounts { get; init; } 
    
    #nullable disable
}
