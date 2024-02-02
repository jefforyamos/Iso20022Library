﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection43.  ISO2002 ID# _4UecAYp5EeS3NqNpgnMh2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed amount.
/// </summary>
[DataContract]
[XmlType]
public partial record AmountAndDirection43
{
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [DataMember]
    public required IsoCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// </summary>
    [DataMember]
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    /// <summary>
    /// Date of the amount.
    /// </summary>
    [DataMember]
    public IsoISODate? Date { get; init; } 
    
    #nullable disable
}
