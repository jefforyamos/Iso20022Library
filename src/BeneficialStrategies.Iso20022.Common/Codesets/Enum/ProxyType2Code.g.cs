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
    /// ??
    /// Encoded/decoded by serializers as "Chairman".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZWd-KNp-Ed-ak6NoX_4Aeg_-885468111")]
    [Description(@"??")]
    Chairman,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Discretionary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZWnIENp-Ed-ak6NoX_4Aeg_-885468041")]
    [Description(@"??")]
    Discretionary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecurityHolder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZWnIEdp-Ed-ak6NoX_4Aeg_-1812267007")]
    [Description(@"??")]
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

