﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Status3Code.  ISO2002 ID# _ZQggEtp-Ed-ak6NoX_4Aeg_-1064258208.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQggEtp-Ed-ak6NoX_4Aeg_-1064258208")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusCode))]
public enum Status3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQggE9p-Ed-ak6NoX_4Aeg_-780737301")]
    [Description(@"??")]
    Cancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQggFNp-Ed-ak6NoX_4Aeg_-763187538")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotReceived".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQggFdp-Ed-ak6NoX_4Aeg_-748412104")]
    [Description(@"??")]
    NotReceived,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Completed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQggFtp-Ed-ak6NoX_4Aeg_-734560081")]
    [Description(@"??")]
    Completed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivedByIssuerOrRegistrar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQggF9p-Ed-ak6NoX_4Aeg_-719784966")]
    [Description(@"??")]
    ReceivedByIssuerOrRegistrar,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQggGNp-Ed-ak6NoX_4Aeg_-695771510")]
    [Description(@"??")]
    StandingInstruction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Status3CodeMetadataExtensions
{
    private static readonly Status3CodeDropdownSource _dropdownSource = new Status3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatus3CodeDropdownRow GetMetadata(this Status3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


