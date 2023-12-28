﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralisationType1Code.  ISO2002 ID# _KepsAPP6EeS_qLctCs2aRQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of collateral agreement between two parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KepsAPP6EeS_qLctCs2aRQ")]
[Description(@"Specifies the type of collateral agreement between two parties.")]
[DerivedFrom(typeof(CollateralisationTypeCode))]
public enum CollateralisationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FullyCollateralised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ofu70fP6EeS_qLctCs2aRQ")]
    [Description(@"??")]
    FullyCollateralised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneWayCollateralised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Op_rEfP6EeS_qLctCs2aRQ")]
    [Description(@"??")]
    OneWayCollateralised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyCollateralised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_O1wPI_P6EeS_qLctCs2aRQ")]
    [Description(@"??")]
    PartiallyCollateralised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Uncollateralised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_O3_DwfP6EeS_qLctCs2aRQ")]
    [Description(@"??")]
    Uncollateralised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralisationType1CodeMetadataExtensions
{
    private static readonly CollateralisationType1CodeDropdownSource _dropdownSource = new CollateralisationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralisationType1CodeDropdownRow GetMetadata(this CollateralisationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

