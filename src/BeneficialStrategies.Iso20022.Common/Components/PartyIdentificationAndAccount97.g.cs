﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount97.  ISO2002 ID# _Sge40zozEeOr__K5A0LSog.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account information.
/// </summary>
public partial record PartyIdentificationAndAccount97
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    public required PartyIdentification62 PartyIdentification { get; init; } 
    /// <summary>
    /// Identification of the account.
    /// </summary>
    public AccountIdentification26? AccountIdentification { get; init; } 
    
    #nullable disable
}
