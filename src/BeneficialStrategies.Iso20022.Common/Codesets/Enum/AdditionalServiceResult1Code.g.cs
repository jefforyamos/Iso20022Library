﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalServiceResult1Code.  ISO2002 ID# _Pw460J1KEeublrfU-wN95w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the result of the service performed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Pw460J1KEeublrfU-wN95w")]
[Description(@"Identifies the result of the service performed.")]
[DerivedFrom(typeof(AdditionalServiceResultCode))]
public enum AdditionalServiceResult1Code
{
    /// <summary>
    /// The service was not performed.
    /// Encoded/decoded by serializers as "NotPerformed".
    /// </summary>
    [EnumMember(Value = "NOPF")]
    [IsoId("_Xz7kMZ1KEeublrfU-wN95w")]
    [Description(@"The service was not performed.")]
    NotPerformed,
    
    /// <summary>
    /// The service is not supported and could not be performed.
    /// Encoded/decoded by serializers as "NotSupported".
    /// </summary>
    [EnumMember(Value = "NOSP")]
    [IsoId("_YQaE0Z1KEeublrfU-wN95w")]
    [Description(@"The service is not supported and could not be performed.")]
    NotSupported,
    
    /// <summary>
    /// Other nationally defined code.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_YREzMZ1KEeublrfU-wN95w")]
    [Description(@"Other nationally defined code.")]
    OtherNational,
    
    /// <summary>
    /// Other privately defined code.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_YRwIoZ1KEeublrfU-wN95w")]
    [Description(@"Other privately defined code.")]
    OtherPrivate,
    
    /// <summary>
    /// The service was performed.
    /// Encoded/decoded by serializers as "Performed".
    /// </summary>
    [EnumMember(Value = "PERF")]
    [IsoId("_YX6bAZ1KEeublrfU-wN95w")]
    [Description(@"The service was performed.")]
    Performed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalServiceResult1CodeMetadataExtensions
{
    private static readonly AdditionalServiceResult1CodeDropdownSource _dropdownSource = new AdditionalServiceResult1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalServiceResult1CodeDropdownRow GetMetadata(this AdditionalServiceResult1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


