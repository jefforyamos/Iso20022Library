﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundPlanType1Code.  ISO2002 ID# _C-csoF9CEeicg40_9gK9vQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "INVP".
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_ORZ8sV9EEeicg40_9gK9vQ")]
    [Description(@"Savings investment plan.")]
    SavingsInvestmentPlan = InvestmentFundPlanTypeCode.SavingsInvestmentPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Switch plan.
    /// Encoded/decoded by serializers as "SWIP".
    /// </summary>
    [EnumMember(Value = "SWIP")]
    [IsoId("_OW2dYV9EEeicg40_9gK9vQ")]
    [Description(@"Switch plan.")]
    SwitchPlan = InvestmentFundPlanTypeCode.SwitchPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal plan.
    /// Encoded/decoded by serializers as "WTHP".
    /// </summary>
    [EnumMember(Value = "WTHP")]
    [IsoId("_Oc3l0V9EEeicg40_9gK9vQ")]
    [Description(@"Withdrawal plan.")]
    WithdrawalPlan = InvestmentFundPlanTypeCode.WithdrawalPlan, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundPlanType1CodeMetadataExtensions
{
    private static readonly InvestmentFundPlanType1CodeDropdownSource _dropdownSource = new InvestmentFundPlanType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundPlanType1CodeDropdownRow GetMetadata(this InvestmentFundPlanType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


