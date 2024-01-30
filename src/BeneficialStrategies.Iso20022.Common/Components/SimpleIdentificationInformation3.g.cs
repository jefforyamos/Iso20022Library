﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SimpleIdentificationInformation3.  ISO2002 ID# _WIiCitp-Ed-ak6NoX_4Aeg_-2033931767.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a party identification or account identification.
/// </summary>
public partial record SimpleIdentificationInformation3
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    public required IsoMax34Text Identification { get; init; } 
    
    #nullable disable
}
