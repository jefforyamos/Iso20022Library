﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundPlanTypeCode.  ISO2002 ID# _sH2IUF9BEeicg40_9gK9vQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifes a type of investment fund plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sH2IUF9BEeicg40_9gK9vQ")]
[Description(@"Specifes a type of investment fund plan.")]
[Derivations(typeof(InvestmentFundPlanType1Code))]
public enum InvestmentFundPlanTypeCode
{
    /// <summary>
    /// Savings investment plan.
    /// Encoded/decoded by serializers as "INVP".
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_xwSXgF9BEeicg40_9gK9vQ")]
    [Description(@"Savings investment plan.")]
    SavingsInvestmentPlan,
    
    /// <summary>
    /// Withdrawal plan.
    /// Encoded/decoded by serializers as "WTHP".
    /// </summary>
    [EnumMember(Value = "WTHP")]
    [IsoId("_0aRRgF9BEeicg40_9gK9vQ")]
    [Description(@"Withdrawal plan.")]
    WithdrawalPlan,
    
    /// <summary>
    /// Switch plan.
    /// Encoded/decoded by serializers as "SWIP".
    /// </summary>
    [EnumMember(Value = "SWIP")]
    [IsoId("_2F9XQF9BEeicg40_9gK9vQ")]
    [Description(@"Switch plan.")]
    SwitchPlan,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundPlanTypeCodeMetadataExtensions
{
    private static readonly InvestmentFundPlanTypeCodeDropdownSource _dropdownSource = new InvestmentFundPlanTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundPlanTypeCodeDropdownRow GetMetadata(this InvestmentFundPlanTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


