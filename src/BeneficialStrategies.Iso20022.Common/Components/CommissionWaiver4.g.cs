﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommissionWaiver4.  ISO2002 ID# _55smERuCEeOqSdXzJ0oydA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
/// </summary>
public partial record CommissionWaiver4
{
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, for example, cash.
    /// </summary>
    public required WaivingInstruction1Choice_ InstructionBasis { get; init; } 
    /// <summary>
    /// Proportion of the commission that is waived, for example, if the commission is 5% and half is waived, 2.5% should be stated in this field.
    /// </summary>
    public required IsoPercentageRate WaivedRate { get; init; } 
    
    #nullable disable
}
