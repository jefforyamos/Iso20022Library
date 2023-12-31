﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason8Code.  ISO2002 ID# _WOybgtp-Ed-ak6NoX_4Aeg_-1191324327.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOybgtp-Ed-ak6NoX_4Aeg_-1191324327")]
[Description(@"Specifies the underlying reason for cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonCode))]
public enum CancelledStatusReason8Code
{
    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, eg, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as "CancelledByOther".
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_WOybg9p-Ed-ak6NoX_4Aeg_-1191324296")]
    [Description(@"Transaction is cancelled by a party other than the instructing party, eg, a market infrastructure such as a stock exchange.")]
    CancelledByOther,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancelledStatusReason8CodeMetadataExtensions
{
    private static readonly CancelledStatusReason8CodeDropdownSource _dropdownSource = new CancelledStatusReason8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancelledStatusReason8CodeDropdownRow GetMetadata(this CancelledStatusReason8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


