﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EnabledStatusReason1Code.  ISO2002 ID# _LCqQYGBhEeaR1OOiVxm3Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for an enabled status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LCqQYGBhEeaR1OOiVxm3Gg")]
[Description(@"Specifies the reason for an enabled status.")]
[DerivedFrom(typeof(EnabledStatusReasonCode))]
public enum EnabledStatusReason1Code
{
    /// <summary>
    /// Modification to the account data is in process.
    /// Encoded/decoded by serializers as "Modified".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_MrP-0WBhEeaR1OOiVxm3Gg")]
    [Description(@"Modification to the account data is in process.")]
    Modified,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EnabledStatusReason1CodeMetadataExtensions
{
    private static readonly EnabledStatusReason1CodeDropdownSource _dropdownSource = new EnabledStatusReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEnabledStatusReason1CodeDropdownRow GetMetadata(this EnabledStatusReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


