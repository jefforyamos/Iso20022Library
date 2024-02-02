﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateTypeAndAmountAndStatus6.  ISO2002 ID# _UOMcwNp-Ed-ak6NoX_4Aeg_1551032160.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value expressed as a rate and an amount.
/// </summary>
[DataContract]
[XmlType]
public partial record RateTypeAndAmountAndStatus6
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [DataMember]
    public required RateType11Choice_ RateType { get; init; } 
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [DataMember]
    public RateStatus1Choice_? RateStatus { get; init; } 
    
    #nullable disable
}
