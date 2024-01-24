﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesPaymentStatusCode.  ISO2002 ID# _ZFx2wdp-Ed-ak6NoX_4Aeg_274626372.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of payment of a security at a particular time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFx2wdp-Ed-ak6NoX_4Aeg_274626372")]
[Description(@"Specifies the state of payment of a security at a particular time.")]
[Derivations(typeof(SecuritiesPaymentStatus1Code))]
public enum SecuritiesPaymentStatusCode
{
    /// <summary>
    /// Security is fully paid.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_ZFx2wtp-Ed-ak6NoX_4Aeg_274626433")]
    [Description(@"Security is fully paid.")]
    FullyPaid,
    
    /// <summary>
    /// Security is nill paid.
    /// Encoded/decoded by serializers as "NILL".
    /// </summary>
    [EnumMember(Value = "NILL")]
    [IsoId("_ZFx2w9p-Ed-ak6NoX_4Aeg_274626464")]
    [Description(@"Security is nill paid.")]
    NillPaid,
    
    /// <summary>
    /// Security is partially paid.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZFx2xNp-Ed-ak6NoX_4Aeg_274626494")]
    [Description(@"Security is partially paid.")]
    PartiallyPaid,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesPaymentStatusCodeMetadataExtensions
{
    private static readonly SecuritiesPaymentStatusCodeDropdownSource _dropdownSource = new SecuritiesPaymentStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesPaymentStatusCodeDropdownRow GetMetadata(this SecuritiesPaymentStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


