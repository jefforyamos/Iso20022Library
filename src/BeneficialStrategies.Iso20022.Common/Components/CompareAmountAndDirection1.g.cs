﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareAmountAndDirection1.  ISO2002 ID# _KdA98cptEemrr60nKZj5JQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an active or historic currency and amount and direction
/// </summary>
[DataContract]
[XmlType]
public partial record CompareAmountAndDirection1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [DataMember]
    public AmountAndDirection53? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [DataMember]
    public AmountAndDirection53? Value2 { get; init; } 
    
    #nullable disable
}
