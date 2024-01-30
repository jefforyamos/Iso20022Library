﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SearchOutputOrder1.  ISO2002 ID# _s9PP4N6QEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the ordering in which the resulting transaction reports should be returned.
/// </summary>
public partial record SearchOutputOrder1
{
    #nullable enable
    
    /// <summary>
    /// Ordering criteria for the transaction report.
    /// </summary>
    public CriteriaOrder1? CriteriaOrder { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
