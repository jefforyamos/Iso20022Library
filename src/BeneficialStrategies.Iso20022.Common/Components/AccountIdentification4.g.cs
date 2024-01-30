﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification4.  ISO2002 ID# _WO8MiNp-Ed-ak6NoX_4Aeg_672442635.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier of an account, as assigned by the account servicer.
/// </summary>
public partial record AccountIdentification4
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for an account. It is assigned by the account servicer using a proprietary identification scheme.
    /// </summary>
    public required SimpleIdentificationInformation1 Proprietary { get; init; } 
    
    #nullable disable
}
