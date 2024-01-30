﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MemberSearchCriteria2.  ISO2002 ID# _8G7QcaMgEeCJ6YNENx4h-w_1746030860.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a member.
/// </summary>
public partial record MemberSearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public IMemberIdentification2Choice? Identification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    public MemberType1Code? Type { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Status of a member in a system, such as enabled or deleted.
    /// </summary>
    public MemberStatus1Code? Status { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
