﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LockStatus1Code.  ISO2002 ID# _mrGisGjMEeiRg5NzP0jkQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the lock status of a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mrGisGjMEeiRg5NzP0jkQg")]
[Description(@"Specifies the lock status of a party.")]
[DerivedFrom(typeof(LockStatusCode))]
public enum LockStatus1Code
{
    /// <summary>
    /// Party has been locked for operations.
    /// Encoded/decoded by serializers as "Locked".
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_oSkPwWjMEeiRg5NzP0jkQg")]
    [Description(@"Party has been locked for operations.")]
    Locked,
    
    /// <summary>
    /// Party is ready for operations.
    /// Encoded/decoded by serializers as "Unlocked".
    /// </summary>
    [EnumMember(Value = "ULCK")]
    [IsoId("_oYLIgWjMEeiRg5NzP0jkQg")]
    [Description(@"Party is ready for operations.")]
    Unlocked,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LockStatus1CodeMetadataExtensions
{
    private static readonly LockStatus1CodeDropdownSource _dropdownSource = new LockStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILockStatus1CodeDropdownRow GetMetadata(this LockStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


