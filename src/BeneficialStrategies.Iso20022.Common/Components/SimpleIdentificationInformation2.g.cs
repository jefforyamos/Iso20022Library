﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SimpleIdentificationInformation2.  ISO2002 ID# _P_luWNp-Ed-ak6NoX_4Aeg_618188227.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a party identification or account identification.
/// </summary>
public partial record SimpleIdentificationInformation2
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    public required IsoMax34Text Identification { get; init; } 
    
    #nullable disable
}
