﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProxyNotAllowedCode.  ISO2002 ID# _ZWd-Jdp-Ed-ak6NoX_4Aeg_-1352917034.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates that the assignment of a proxy is not allowed for the meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZWd-Jdp-Ed-ak6NoX_4Aeg_-1352917034")]
[Description(@"Indicates that the assignment of a proxy is not allowed for the meeting.")]
[Derivations(typeof(ProxyNotAllowed1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ProxyNotAllowedCode
{
    /// <summary>
    /// Proxy not allowed.
    /// Encoded/decoded by serializers as "NPRO".
    /// </summary>
    [EnumMember(Value = "NPRO")]
    [IsoId("_ZWd-Jtp-Ed-ak6NoX_4Aeg_-1195919766")]
    [Description(@"Proxy not allowed.")]
    NotAllowed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProxyNotAllowedCodeMetadataExtensions
{
    private static readonly ProxyNotAllowedCodeDropdownSource _dropdownSource = new ProxyNotAllowedCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProxyNotAllowedCodeDropdownRow GetMetadata(this ProxyNotAllowedCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


