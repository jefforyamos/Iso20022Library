﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundPlanType1Code.  ISO2002 ID# _C-csoF9CEeicg40_9gK9vQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of investment fund plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C-csoF9CEeicg40_9gK9vQ")]
[Description(@"Specifies a type of investment fund plan.")]
[DerivedFrom(typeof(InvestmentFundPlanTypeCode))]
public enum InvestmentFundPlanType1Code
{
    /// <summary>
    /// Savings investment plan.
    /// Encoded/decoded by serializers as &quot;INVP&quot;.
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_ORZ8sV9EEeicg40_9gK9vQ")]
    [Description(@"Savings investment plan.")]
    SavingsInvestmentPlan = InvestmentFundPlanTypeCode.SavingsInvestmentPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Switch plan.
    /// Encoded/decoded by serializers as &quot;SWIP&quot;.
    /// </summary>
    [EnumMember(Value = "SWIP")]
    [IsoId("_OW2dYV9EEeicg40_9gK9vQ")]
    [Description(@"Switch plan.")]
    SwitchPlan = InvestmentFundPlanTypeCode.SwitchPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal plan.
    /// Encoded/decoded by serializers as &quot;WTHP&quot;.
    /// </summary>
    [EnumMember(Value = "WTHP")]
    [IsoId("_Oc3l0V9EEeicg40_9gK9vQ")]
    [Description(@"Withdrawal plan.")]
    WithdrawalPlan = InvestmentFundPlanTypeCode.WithdrawalPlan, // same ordinal as derivation source for type conversions
    
}
