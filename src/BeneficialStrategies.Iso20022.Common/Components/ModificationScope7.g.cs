﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope7.  ISO2002 ID# _RRZUddp-Ed-ak6NoX_4Aeg_1555387855.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[DataContract]
[XmlType]
public partial record ModificationScope7
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [DataMember]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Information related to intermediaries.
    /// </summary>
    [DataMember]
    public required Intermediary13 Intermediary { get; init; } 
    
    #nullable disable
}
