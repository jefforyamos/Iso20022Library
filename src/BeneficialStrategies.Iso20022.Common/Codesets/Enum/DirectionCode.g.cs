﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DirectionCode.  ISO2002 ID# _awK8BNp-Ed-ak6NoX_4Aeg_1863385862.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the direction of a payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awK8BNp-Ed-ak6NoX_4Aeg_1863385862")]
[Description(@"Specifies the direction of a payment.")]
public enum DirectionCode
{
    /// <summary>
    /// Down.
    /// </summary>
    [EnumMember(Value = "DRDW")]
    [IsoId("_awK8Bdp-Ed-ak6NoX_4Aeg_1863385879")]
    [Description(@"Down.")]
    DRDW,
    
    /// <summary>
    /// Up.
    /// </summary>
    [EnumMember(Value = "DRUP")]
    [IsoId("_awK8Btp-Ed-ak6NoX_4Aeg_1863385888")]
    [Description(@"Up.")]
    DRUP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DirectionCodeMetadataExtensions
{
    private static readonly DirectionCodeDropdownSource _dropdownSource = new DirectionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDirectionCodeDropdownRow GetMetadata(this DirectionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


