﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CallTypeCode.  ISO2002 ID# _ha1jt2liEeGaMcKyqKNRfQ_1405973074.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of execution of the call feature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha1jt2liEeGaMcKyqKNRfQ_1405973074")]
[Description(@"Defines the type of execution of the call feature.")]
public enum CallTypeCode
{
    /// <summary>
    /// Type of execution of the call feature is a lottery.
    /// Encoded/decoded by serializers as "LOTT".
    /// </summary>
    [EnumMember(Value = "LOTT")]
    [IsoId("_ha1juGliEeGaMcKyqKNRfQ_-1311622256")]
    [Description(@"Type of execution of the call feature is a lottery.")]
    Lottery,
    
    /// <summary>
    /// Type of execution of the call feature is pro-rata.
    /// Encoded/decoded by serializers as "PRTA".
    /// </summary>
    [EnumMember(Value = "PRTA")]
    [IsoId("_ha1juWliEeGaMcKyqKNRfQ_253023576")]
    [Description(@"Type of execution of the call feature is pro-rata.")]
    ProRata,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CallTypeCodeMetadataExtensions
{
    private static readonly CallTypeCodeDropdownSource _dropdownSource = new CallTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICallTypeCodeDropdownRow GetMetadata(this CallTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


