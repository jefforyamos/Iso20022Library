﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MissingOrIncorrectInformation1.  ISO2002 ID# _T-ZtStp-Ed-ak6NoX_4Aeg_-1840697394.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reason for the UnableToApply. It can be missing and/or incorrect information.
/// </summary>
[DataContract]
[XmlType]
public partial record MissingOrIncorrectInformation1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    [DataMember]
    public ValueList<UnableToApplyMissingInfo1Code> MissingInformation { get; init; } = [];
    /// <summary>
    /// Indicates the incorrect information.
    /// </summary>
    [DataMember]
    public ValueList<UnableToApplyIncorrectInfo2Code> IncorrectInformation { get; init; } = [];
    
    #nullable disable
}
