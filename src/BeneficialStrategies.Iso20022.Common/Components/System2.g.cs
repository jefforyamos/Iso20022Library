﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for System2.  ISO2002 ID# _BIwgSW4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Search for a system and a member of a system.
/// </summary>
public partial record System2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public IMarketInfrastructureIdentification1Choice? SystemIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? MemberIdentification { get; init; } 
    /// <summary>
    /// Country in which the system is located.
    /// </summary>
    public CountryCode? Country { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentification4Choice? AccountIdentification { get; init; } 
    
    #nullable disable
}
