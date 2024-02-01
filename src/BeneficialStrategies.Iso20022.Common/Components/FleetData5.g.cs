﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FleetData5.  ISO2002 ID# _FEPHAR1TEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet data pertaining to the payment transaction.
/// </summary>
public partial record FleetData5
{
    #nullable enable
    
    /// <summary>
    /// It is designed to carry detail level fleet data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to fleet transactions. 
    /// </summary>
    public FleetLineItem3[] LineItem { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
