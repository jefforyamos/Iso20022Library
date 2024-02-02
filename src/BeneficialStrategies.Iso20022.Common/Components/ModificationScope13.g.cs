﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope13.  ISO2002 ID# _CfguYRKwEeKj15WxqwlXPw.
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
public partial record ModificationScope13
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [DataMember]
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Information related to the account to be modified.
    /// </summary>
    [DataMember]
    public required FinancialInstrument29 FundDetails { get; init; } 
    
    #nullable disable
}
