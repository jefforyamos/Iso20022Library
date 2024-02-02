﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Price3.  ISO2002 ID# _WimvZNp-Ed-ak6NoX_4Aeg_1241581910.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type and information about a price.
/// </summary>
[DataContract]
[XmlType]
public partial record Price3
{
    #nullable enable
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [DataMember]
    public required YieldedOrValueType1Choice_ Type { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [DataMember]
    public required PriceRateOrAmount1Choice_ Value { get; init; } 
    
    #nullable disable
}
