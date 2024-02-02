﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DateCodeAndTimeFormat1.  ISO2002 ID# _Q2uKqNp-Ed-ak6NoX_4Aeg_1100233351.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a date code and a time.
/// </summary>
[DataContract]
[XmlType]
public partial record DateCodeAndTimeFormat1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [DataMember]
    public required DateCode4Choice_ DateCode { get; init; } 
    /// <summary>
    /// Specifies the time.
    /// </summary>
    [DataMember]
    public required IsoISOTime Time { get; init; } 
    
    #nullable disable
}
