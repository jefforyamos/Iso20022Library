﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MemberReport6.  ISO2002 ID# _fODoVdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on a member or a business error.
/// </summary>
public partial record MemberReport6
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    /// <summary>
    /// Reports either on a member or a business error.
    /// </summary>
    public required MemberReportOrError8Choice_ MemberOrError { get; init; } 
    
    #nullable disable
}
