﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarginCall2.  ISO2002 ID# _gfK1AILVEeWrrO9HojbPQA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the calculation and the resulting margin and independent amount needed to cover the risk exposure of one party versus another.
/// </summary>
public partial record MarginCall2
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    public CollateralAccount2? CollateralAccountIdentification { get; init; } 
    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    public required MarginCallResult3 MarginCallResult { get; init; } 
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    public MarginCall1? MarginDetailDueToA { get; init; } 
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    public MarginCall1? MarginDetailDueToB { get; init; } 
    /// <summary>
    /// Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; init; } 
    /// <summary>
    /// Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; init; } 
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToA { get; init; } 
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToB { get; init; } 
    
    #nullable disable
}
