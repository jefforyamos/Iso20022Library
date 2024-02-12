﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralAppliedExcessCode.  ISO2002 ID# _G4ohQAF5EeutW5-TpeYJhA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if the collateral reported is applied or in excess.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G4ohQAF5EeutW5-TpeYJhA")]
[Description(@"Indicates if the collateral reported is applied or in excess.|")]
[Derivations(typeof(CollateralAppliedExcess1Code))]
public enum CollateralAppliedExcessCode
{
    /// <summary>
    /// Collateral used by the collateral receiver to discharge liabilities owed to it by the collateral provider.
    /// Encoded/decoded by serializers as "APLD".
    /// </summary>
    [EnumMember(Value = "APLD")]
    [IsoId("_MaRvcAF6EeutW5-TpeYJhA")]
    [Description(@"Collateral used by the collateral receiver to discharge liabilities owed to it by the collateral provider.|")]
    Applied,
    
    /// <summary>
    /// Collateral held by the collateral receiver either in anticipation of future liabilities or towards previously liabilities no longer owed to it.
    /// Encoded/decoded by serializers as "EXCS".
    /// </summary>
    [EnumMember(Value = "EXCS")]
    [IsoId("_WGhLQAF6EeutW5-TpeYJhA")]
    [Description(@"Collateral held by the collateral receiver either in anticipation of future liabilities or towards previously liabilities no longer owed to it.|")]
    Excess,
    
}
