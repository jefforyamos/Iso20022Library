﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FromToAmountRange1.  ISO2002 ID# _jomKS5ljEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of amount values.
/// </summary>
[DataContract]
[XmlType]
public partial record FromToAmountRange1
{
    #nullable enable
    
    /// <summary>
    /// Lower boundary of a range of amount values.
    /// </summary>
    [DataMember]
    public required AmountRangeBoundary1 FromAmount { get; init; } 
    /// <summary>
    /// Upper boundary of a range of amount values.
    /// </summary>
    [DataMember]
    public required AmountRangeBoundary1 ToAmount { get; init; } 
    
    #nullable disable
}
