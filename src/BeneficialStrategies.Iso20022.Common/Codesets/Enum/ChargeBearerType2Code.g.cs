﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargeBearerType2Code.  ISO2002 ID# _a8PpJdp-Ed-ak6NoX_4Aeg_-867377904.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8PpJdp-Ed-ak6NoX_4Aeg_-867377904")]
[Description(@"Specifies which party(ies) will pay charges due for processing of the instruction.")]
[DerivedFrom(typeof(ChargeBearerTypeCode))]
public enum ChargeBearerType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FollowingServiceLevel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a8PpJtp-Ed-ak6NoX_4Aeg_-867377749")]
    [Description(@"??")]
    FollowingServiceLevel,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargeBearerType2CodeMetadataExtensions
{
    private static readonly ChargeBearerType2CodeDropdownSource _dropdownSource = new ChargeBearerType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargeBearerType2CodeDropdownRow GetMetadata(this ChargeBearerType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

