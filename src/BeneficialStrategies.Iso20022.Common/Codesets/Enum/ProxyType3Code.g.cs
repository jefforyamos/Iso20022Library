﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProxyType3Code.  ISO2002 ID# _X2Qi8BrfEeyhRdHRjakS2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of proxy person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X2Qi8BrfEeyhRdHRjakS2w")]
[Description(@"Specifies the type of proxy person.")]
[DerivedFrom(typeof(ProxyTypeCode))]
public enum ProxyType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Chairman".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cpOisRrfEeyhRdHRjakS2w")]
    [Description(@"??")]
    Chairman,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Discretionary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ctjCARrfEeyhRdHRjakS2w")]
    [Description(@"??")]
    Discretionary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NeutralProxy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cyUNQRrfEeyhRdHRjakS2w")]
    [Description(@"??")]
    NeutralProxy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecurityHolder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c2ydkRrfEeyhRdHRjakS2w")]
    [Description(@"??")]
    SecurityHolder,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProxyType3CodeMetadataExtensions
{
    private static readonly ProxyType3CodeDropdownSource _dropdownSource = new ProxyType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProxyType3CodeDropdownRow GetMetadata(this ProxyType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

