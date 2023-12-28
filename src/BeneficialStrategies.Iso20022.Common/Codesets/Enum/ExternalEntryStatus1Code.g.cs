﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalEntryStatus1Code.  ISO2002 ID# __lGEsK6IEeexrtTFgmVD3Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an entry on the books of the account servicer, as published in an external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__lGEsK6IEeexrtTFgmVD3Q")]
[Description(@"Specifies the status of an entry on the books of the account servicer, as published in an external code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalEntryStatusCode))]
public enum ExternalEntryStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Booked".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubgTQvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Booked,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Future".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubgTRfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Future,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Information".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubgTSPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Information,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ubgTS_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Pending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalEntryStatus1CodeMetadataExtensions
{
    private static readonly ExternalEntryStatus1CodeDropdownSource _dropdownSource = new ExternalEntryStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalEntryStatus1CodeDropdownRow GetMetadata(this ExternalEntryStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


