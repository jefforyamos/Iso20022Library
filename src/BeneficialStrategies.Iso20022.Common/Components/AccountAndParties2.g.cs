﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountAndParties2.  ISO2002 ID# _ApDrEC_9EeOKib24wnHaFg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the account and the role of the party.
/// </summary>
public partial record AccountAndParties2
{
    #nullable enable
    
    /// <summary>
    /// Description of the account.
    /// </summary>
    public required CustomerAccount1 Account { get; init; } 
    /// <summary>
    /// Specifies the role related to the account.
    /// </summary>
    public AccountRole1[] Role { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information.
    /// </summary>
    public IsoMax256Text[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
