﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargeTaxBasis1Code.  ISO2002 ID# __05YtdojEeC60axPepSq7g_-2079175489.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Define the Charges/tax basis for the trade being allocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__05YtdojEeC60axPepSq7g_-2079175489")]
[Description(@"Define the Charges/tax basis for the trade being allocated.")]
[DerivedFrom(typeof(ChargeTaxBasisCode))]
public enum ChargeTaxBasis1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FlatOrAbsolute".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__05YttojEeC60axPepSq7g_2090853964")]
    [Description(@"??")]
    FlatOrAbsolute,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PerUnit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1DJsNojEeC60axPepSq7g_203767408")]
    [Description(@"??")]
    PerUnit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargeTaxBasis1CodeMetadataExtensions
{
    private static readonly ChargeTaxBasis1CodeDropdownSource _dropdownSource = new ChargeTaxBasis1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargeTaxBasis1CodeDropdownRow GetMetadata(this ChargeTaxBasis1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

