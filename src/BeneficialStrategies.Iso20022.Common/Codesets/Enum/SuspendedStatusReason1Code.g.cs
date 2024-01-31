﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SuspendedStatusReason1Code.  ISO2002 ID# _ZQzbA9p-Ed-ak6NoX_4Aeg_689720893.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Transaction/instruction is suspended following your earlier suspension instruction.
    /// Encoded/decoded by serializers as "SUBY".
    /// </summary>
    [EnumMember(Value = "SUBY")]
    [IsoId("_ZQzbBNp-Ed-ak6NoX_4Aeg_689720894")]
    [Description(@"Transaction/instruction is suspended following your earlier suspension instruction.")]
    SuspendedByYourself = SuspendedStatusReasonCode.SuspendedByYourself, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction/instruction is suspended following a system suspension instruction.
    /// Encoded/decoded by serializers as "SUBS".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZQzbBdp-Ed-ak6NoX_4Aeg_689720895")]
    [Description(@"Transaction/instruction is suspended following a system suspension instruction.")]
    SuspendedBySystem = SuspendedStatusReasonCode.SuspendedBySystem, // same ordinal as derivation source for type conversions
    
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


