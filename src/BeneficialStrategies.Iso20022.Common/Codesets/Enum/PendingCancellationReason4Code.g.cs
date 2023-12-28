﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingCancellationReason4Code.  ISO2002 ID# _Z-QW4Np-Ed-ak6NoX_4Aeg_2142368384.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Standard code to specify.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z-QW4Np-Ed-ak6NoX_4Aeg_2142368384")]
[Description(@"Standard code to specify.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum PendingCancellationReason4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z-QW4dp-Ed-ak6NoX_4Aeg_-2080565714")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z-QW4tp-Ed-ak6NoX_4Aeg_-2052858643")]
    [Description(@"??")]
    QuantityRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z-QW49p-Ed-ak6NoX_4Aeg_-1791501706")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z-QW5Np-Ed-ak6NoX_4Aeg_-1763795962")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingCancellationReason4CodeMetadataExtensions
{
    private static readonly PendingCancellationReason4CodeDropdownSource _dropdownSource = new PendingCancellationReason4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingCancellationReason4CodeDropdownRow GetMetadata(this PendingCancellationReason4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

