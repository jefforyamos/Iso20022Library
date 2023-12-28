﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ConsolidationType1Code.  ISO2002 ID# _3fs5YCDVEeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the consolidation type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3fs5YCDVEeWCLu74WLgP4w")]
[Description(@"Specifies the consolidation type.")]
[DerivedFrom(typeof(ConsolidationTypeCode))]
public enum ConsolidationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "General".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5ZjW8SDVEeWCLu74WLgP4w")]
    [Description(@"??")]
    General,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Participation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5i6uUSDVEeWCLu74WLgP4w")]
    [Description(@"??")]
    Participation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ConsolidationType1CodeMetadataExtensions
{
    private static readonly ConsolidationType1CodeDropdownSource _dropdownSource = new ConsolidationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IConsolidationType1CodeDropdownRow GetMetadata(this ConsolidationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

