﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SubscriptionRequestCode.  ISO2002 ID# _ZQpqCNp-Ed-ak6NoX_4Aeg_336259528.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of subscription to market data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQpqCNp-Ed-ak6NoX_4Aeg_336259528")]
[Description(@"Type of subscription to market data.")]
public enum SubscriptionRequestCode
{
    /// <summary>
    /// Specifies that the request is to subscribe to snapshots.
    /// Encoded/decoded by serializers as "SNAP".
    /// </summary>
    [EnumMember(Value = "SNAP")]
    [IsoId("_ZQzbANp-Ed-ak6NoX_4Aeg_336259529")]
    [Description(@"Specifies that the request is to subscribe to snapshots.")]
    Snapshot,
    
    /// <summary>
    /// Specifies that the request is to subscribe to snapshots and updates.
    /// Encoded/decoded by serializers as "SUBS".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZQzbAdp-Ed-ak6NoX_4Aeg_336259530")]
    [Description(@"Specifies that the request is to subscribe to snapshots and updates.")]
    Subscribe,
    
    /// <summary>
    /// Specifies that the request is to disable the previous snapshot subscription and to update the request (unsubscribe).
    /// Encoded/decoded by serializers as "UNSU".
    /// </summary>
    [EnumMember(Value = "UNSU")]
    [IsoId("_ZQzbAtp-Ed-ak6NoX_4Aeg_336259531")]
    [Description(@"Specifies that the request is to disable the previous snapshot subscription and to update the request (unsubscribe).")]
    Unsubscribe,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SubscriptionRequestCodeMetadataExtensions
{
    private static readonly SubscriptionRequestCodeDropdownSource _dropdownSource = new SubscriptionRequestCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISubscriptionRequestCodeDropdownRow GetMetadata(this SubscriptionRequestCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

