﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitIdentification6.  ISO2002 ID# __4vC3249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the elements used to uniquely identify a risk management limit defined in the system.
/// </summary>
public partial record LimitIdentification6
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public ISystemIdentification2Choice? SystemIdentification { get; init; } 
    /// <summary>
    /// Nature of the risk management limit.
    /// </summary>
    public required ILimitType1Choice Type { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentification4Choice? AccountIdentification { get; init; } 
    
    #nullable disable
}
