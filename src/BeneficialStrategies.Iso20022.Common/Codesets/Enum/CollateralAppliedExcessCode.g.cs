﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralAppliedExcessCode.  ISO2002 ID# _G4ohQAF5EeutW5-TpeYJhA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if the collateral reported is applied or in excess.
/// 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G4ohQAF5EeutW5-TpeYJhA")]
[Description(@"Indicates if the collateral reported is applied or in excess. ")]
public enum CollateralAppliedExcessCode
{
    /// <summary>
    /// Collateral used by the collateral receiver to discharge liabilities owed to it by the collateral provider.
    /// 
    /// Encoded/decoded by serializers as "APLD".
    /// </summary>
    [EnumMember(Value = "APLD")]
    [IsoId("_MaRvcAF6EeutW5-TpeYJhA")]
    [Description(@"Collateral used by the collateral receiver to discharge liabilities owed to it by the collateral provider. ")]
    Applied,
    
    /// <summary>
    /// Collateral held by the collateral receiver either in anticipation of future liabilities or towards previously liabilities no longer owed to it.
    /// 
    /// Encoded/decoded by serializers as "EXCS".
    /// </summary>
    [EnumMember(Value = "EXCS")]
    [IsoId("_WGhLQAF6EeutW5-TpeYJhA")]
    [Description(@"Collateral held by the collateral receiver either in anticipation of future liabilities or towards previously liabilities no longer owed to it. ")]
    Excess,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralAppliedExcessCodeMetadataExtensions
{
    private static readonly CollateralAppliedExcessCodeDropdownSource _dropdownSource = new CollateralAppliedExcessCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralAppliedExcessCodeDropdownRow GetMetadata(this CollateralAppliedExcessCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

