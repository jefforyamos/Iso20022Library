﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClosedStatusReason1Code.  ISO2002 ID# _Sx9Z8E_wEeaB8-OWTiMVrQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the closed status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sx9Z8E_wEeaB8-OWTiMVrQ")]
[Description(@"Specifies the reason for the closed status.")]
[DerivedFrom(typeof(ClosedStatusReasonCode))]
public enum ClosedStatusReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vq4u4U_wEeaB8-OWTiMVrQ")]
    [Description(@"??")]
    AccountServicerInstruction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClientInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_V0joQU_wEeaB8-OWTiMVrQ")]
    [Description(@"??")]
    ClientInstruction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClosedStatusReason1CodeMetadataExtensions
{
    private static readonly ClosedStatusReason1CodeDropdownSource _dropdownSource = new ClosedStatusReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClosedStatusReason1CodeDropdownRow GetMetadata(this ClosedStatusReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

