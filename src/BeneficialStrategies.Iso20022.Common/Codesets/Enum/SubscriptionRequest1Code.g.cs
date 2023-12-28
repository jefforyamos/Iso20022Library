﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SubscriptionRequest1Code.  ISO2002 ID# _ZQpqBNp-Ed-ak6NoX_4Aeg_-1118188271.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of subscription to market data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQpqBNp-Ed-ak6NoX_4Aeg_-1118188271")]
[Description(@"Type of subscription to market data.")]
[DerivedFrom(typeof(SubscriptionRequestCode))]
public enum SubscriptionRequest1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Snapshot".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQpqBdp-Ed-ak6NoX_4Aeg_-1044305239")]
    [Description(@"??")]
    Snapshot,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Subscribe".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQpqBtp-Ed-ak6NoX_4Aeg_-1044305197")]
    [Description(@"??")]
    Subscribe,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unsubscribe".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQpqB9p-Ed-ak6NoX_4Aeg_-1044305162")]
    [Description(@"??")]
    Unsubscribe,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SubscriptionRequest1CodeMetadataExtensions
{
    private static readonly SubscriptionRequest1CodeDropdownSource _dropdownSource = new SubscriptionRequest1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISubscriptionRequest1CodeDropdownRow GetMetadata(this SubscriptionRequest1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


