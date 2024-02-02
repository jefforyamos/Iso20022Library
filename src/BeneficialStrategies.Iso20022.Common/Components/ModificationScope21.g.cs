﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope21.  ISO2002 ID# _0cGHCwgpEeSUG-8hqXsVMQ.
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
public partial record ModificationScope21
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [DataMember]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Information about the investment account ownership with respect to new issue allocation for a hedge fund.
    /// </summary>
    [DataMember]
    public required NewIssueAllocation2 IssueAllocation { get; init; } 
    
    #nullable disable
}
