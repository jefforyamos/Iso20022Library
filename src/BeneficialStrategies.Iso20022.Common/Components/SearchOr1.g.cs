﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SearchOr1.  ISO2002 ID# _BBbMYN6QEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of criteria following the OR logic.
/// </summary>
[DataContract]
[XmlType]
public partial record SearchOr1
{
    #nullable enable
    
    /// <summary>
    /// List of criteria following the AND logic.
    /// </summary>
    [DataMember]
    public ValueList<SearchAnd1> SearchAnd { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
