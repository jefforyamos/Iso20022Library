﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LegSwapType1Code.  ISO2002 ID# _aeSh0dp-Ed-ak6NoX_4Aeg_-167248068.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of leg structuring a swap. For fixed income, it is used to requests the respondent to calculate the quantity based on the quantity on the opposite side of the swap.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aeSh0dp-Ed-ak6NoX_4Aeg_-167248068")]
[Description(@"Indicates the type of leg structuring a swap. For fixed income, it is used to requests the respondent to calculate the quantity based on the quantity on the opposite side of the swap.")]
[DerivedFrom(typeof(LegSwapTypeCode))]
public enum LegSwapType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ParForPar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aeSh0tp-Ed-ak6NoX_4Aeg_-130309149")]
    [Description(@"??")]
    ParForPar,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ModifiedDuration".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aeSh09p-Ed-ak6NoX_4Aeg_-130309107")]
    [Description(@"??")]
    ModifiedDuration,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Risk".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aeSh1Np-Ed-ak6NoX_4Aeg_-130309063")]
    [Description(@"??")]
    Risk,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Proceeds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aeSh1dp-Ed-ak6NoX_4Aeg_-130309011")]
    [Description(@"??")]
    Proceeds,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LegSwapType1CodeMetadataExtensions
{
    private static readonly LegSwapType1CodeDropdownSource _dropdownSource = new LegSwapType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILegSwapType1CodeDropdownRow GetMetadata(this LegSwapType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


