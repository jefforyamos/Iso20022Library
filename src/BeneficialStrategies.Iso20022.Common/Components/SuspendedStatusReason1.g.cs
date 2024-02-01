﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SuspendedStatusReason1.  ISO2002 ID# _Uzce5dp-Ed-ak6NoX_4Aeg_-1152969325.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a suspended status.
/// </summary>
public partial record SuspendedStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for a suspended status in structured form.
    /// </summary>
    public SuspendedStatusReason2Code[] Structured { get; init; } = [];
    /// <summary>
    /// Reason for a suspended status in free format text.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
