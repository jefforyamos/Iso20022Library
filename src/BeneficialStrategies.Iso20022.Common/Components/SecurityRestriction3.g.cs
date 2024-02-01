﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityRestriction3.  ISO2002 ID# _cIeP8Wf9Eembv_9KtOEw8g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restrictions applicable to the security.
/// </summary>
public partial record SecurityRestriction3
{
    #nullable enable
    
    /// <summary>
    /// Period during which the restriction applies.
    /// </summary>
    public DateTimePeriod2? EffectivePeriod { get; init; } 
    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    public SecurityRestrictionType2Choice_? RestrictionType { get; init; } 
    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    public LegalRestrictions5Choice_? LegalRestrictionType { get; init; } 
    /// <summary>
    /// Specifies whether the restriction to be applied is relevant for citizen, resident, country.
    /// </summary>
    public InvestorRestrictionType3Choice_[] InvestorRestrictionType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of investor that is allowed to hold the security.
    /// </summary>
    public InvestorType3Choice_[] InvestorType { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
