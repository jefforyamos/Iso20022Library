﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceDisplayRequest3.  ISO2002 ID# _1jAyIS8_Eeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Display Request message.
/// </summary>
public partial record DeviceDisplayRequest3
{
    #nullable enable
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    public ActionMessage8? DisplayOutput { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
