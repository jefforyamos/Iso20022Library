﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractRegistration3.  ISO2002 ID# _JEKGD249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control contract registration details.
/// </summary>
public partial record ContractRegistration3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the contract registration.
    /// </summary>
    public required IsoMax35Text ContractRegistrationIdentification { get; init; } 
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    public required TradeParty5 ReportingParty { get; init; } 
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    /// <summary>
    /// Details about the opening of the contract registration.
    /// </summary>
    public ContractRegistration4[] ContractRegistrationOpening { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
