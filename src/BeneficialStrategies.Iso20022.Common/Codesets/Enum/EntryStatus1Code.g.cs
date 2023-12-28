﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EntryStatus1Code.  ISO2002 ID# _ahauU9p-Ed-ak6NoX_4Aeg_-773188206.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an entry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahauU9p-Ed-ak6NoX_4Aeg_-773188206")]
[Description(@"Specifies the status of an entry.")]
[DerivedFrom(typeof(EntryStatusCode))]
public enum EntryStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Booked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ahauVNp-Ed-ak6NoX_4Aeg_-773188205")]
    [Description(@"??")]
    Booked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ahauVdp-Ed-ak6NoX_4Aeg_-773188204")]
    [Description(@"??")]
    Pending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Future".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ahauVtp-Ed-ak6NoX_4Aeg_-773188203")]
    [Description(@"??")]
    Future,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EntryStatus1CodeMetadataExtensions
{
    private static readonly EntryStatus1CodeDropdownSource _dropdownSource = new EntryStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEntryStatus1CodeDropdownRow GetMetadata(this EntryStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


