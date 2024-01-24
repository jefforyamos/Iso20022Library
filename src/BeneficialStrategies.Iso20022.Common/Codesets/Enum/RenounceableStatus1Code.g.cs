﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RenounceableStatus1Code.  ISO2002 ID# _ZshGqNp-Ed-ak6NoX_4Aeg_-603219895.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the renounceable status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZshGqNp-Ed-ak6NoX_4Aeg_-603219895")]
[Description(@"Specifies the renounceable status.")]
[DerivedFrom(typeof(RenounceableStatusCode))]
public enum RenounceableStatus1Code
{
    /// <summary>
    /// Intermediate securities cannot be sold.
    /// Encoded/decoded by serializers as "NREN".
    /// </summary>
    [EnumMember(Value = "NREN")]
    [IsoId("_Zsq3oNp-Ed-ak6NoX_4Aeg_-603219863")]
    [Description(@"Intermediate securities cannot be sold.")]
    NonRenounceable = RenounceableStatusCode.NonRenounceable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediate securities can be sold.
    /// Encoded/decoded by serializers as "RENO".
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("_Zsq3odp-Ed-ak6NoX_4Aeg_-603219862")]
    [Description(@"Intermediate securities can be sold.")]
    Renounceable = RenounceableStatusCode.Renounceable, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RenounceableStatus1CodeMetadataExtensions
{
    private static readonly RenounceableStatus1CodeDropdownSource _dropdownSource = new RenounceableStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRenounceableStatus1CodeDropdownRow GetMetadata(this RenounceableStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


