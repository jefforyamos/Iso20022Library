﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HoldingsPlanTypeCode.  ISO2002 ID# _1TJzwwnwEeGRcv5_yGDZOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the holdings plan of the assets to transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1TJzwwnwEeGRcv5_yGDZOA")]
[Description(@"Specifies the holdings plan of the assets to transfer.")]
[Derivations(typeof(HoldingsPlanType1Code))]
public enum HoldingsPlanTypeCode
{
    /// <summary>
    /// Holding to be transferred belongs to an investment plan.
    /// Encoded/decoded by serializers as "INVP".
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_Hu7LgAnxEeGRcv5_yGDZOA")]
    [Description(@"Holding to be transferred belongs to an investment plan.")]
    InvestmentPlan,
    
    /// <summary>
    /// Holding to be transferred belongs to a switch plan.
    /// Encoded/decoded by serializers as "SWIP".
    /// </summary>
    [EnumMember(Value = "SWIP")]
    [IsoId("_N0whUAnxEeGRcv5_yGDZOA")]
    [Description(@"Holding to be transferred belongs to a switch plan.")]
    SwitchPlan,
    
    /// <summary>
    /// Holding to be transferred belongs to a withdrawal plan.
    /// Encoded/decoded by serializers as "PLAR".
    /// </summary>
    [EnumMember(Value = "PLAR")]
    [IsoId("_SZt6QAnxEeGRcv5_yGDZOA")]
    [Description(@"Holding to be transferred belongs to a withdrawal plan.")]
    WithdrawalPlan,
    
}
