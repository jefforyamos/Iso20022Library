﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SuspendedStatusReason1Code.  ISO2002 ID# _ZQzbA9p-Ed-ak6NoX_4Aeg_689720893.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is suspended.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQzbA9p-Ed-ak6NoX_4Aeg_689720893")]
[Description(@"Specifies the reason the transaction/instruction is suspended.")]
[DerivedFrom(typeof(SuspendedStatusReasonCode))]
public enum SuspendedStatusReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SuspendedByYourself".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQzbBNp-Ed-ak6NoX_4Aeg_689720894")]
    [Description(@"??")]
    SuspendedByYourself,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SuspendedBySystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQzbBdp-Ed-ak6NoX_4Aeg_689720895")]
    [Description(@"??")]
    SuspendedBySystem,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SuspendedStatusReason1CodeMetadataExtensions
{
    private static readonly SuspendedStatusReason1CodeDropdownSource _dropdownSource = new SuspendedStatusReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISuspendedStatusReason1CodeDropdownRow GetMetadata(this SuspendedStatusReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


