﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProxyType2Code.  ISO2002 ID# _ZWd-J9p-Ed-ak6NoX_4Aeg_-929799410.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of proxy person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZWd-J9p-Ed-ak6NoX_4Aeg_-929799410")]
[Description(@"Specifies the type of proxy person.")]
[DerivedFrom(typeof(ProxyTypeCode))]
public enum ProxyType2Code
{
    /// <summary>
    /// Chairman of the meeting is the proxy.
    /// Encoded/decoded by serializers as "Chairman".
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_ZWd-KNp-Ed-ak6NoX_4Aeg_-885468111")]
    [Description(@"Chairman of the meeting is the proxy.")]
    Chairman,
    
    /// <summary>
    /// Any type of proxy is allowed.
    /// Encoded/decoded by serializers as "Discretionary".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ZWnIENp-Ed-ak6NoX_4Aeg_-885468041")]
    [Description(@"Any type of proxy is allowed.")]
    Discretionary,
    
    /// <summary>
    /// Proxy can only be a security holder.
    /// Encoded/decoded by serializers as "SecurityHolder".
    /// </summary>
    [EnumMember(Value = "HLDR")]
    [IsoId("_ZWnIEdp-Ed-ak6NoX_4Aeg_-1812267007")]
    [Description(@"Proxy can only be a security holder.")]
    SecurityHolder,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProxyType2CodeMetadataExtensions
{
    private static readonly ProxyType2CodeDropdownSource _dropdownSource = new ProxyType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProxyType2CodeDropdownRow GetMetadata(this ProxyType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


