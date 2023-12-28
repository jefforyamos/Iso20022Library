﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderCancellationStatus1Code.  ISO2002 ID# _aQbsB9p-Ed-ak6NoX_4Aeg_-1213962080.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of the order cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQbsB9p-Ed-ak6NoX_4Aeg_-1213962080")]
[Description(@"Specifies the current status of the order cancellation request.")]
[DerivedFrom(typeof(OrderCancellationStatusCode))]
public enum OrderCancellationStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SentToNextParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aQk18Np-Ed-ak6NoX_4Aeg_-1213961837")]
    [Description(@"??")]
    SentToNextParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancellationPending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aQk18dp-Ed-ak6NoX_4Aeg_-1213961821")]
    [Description(@"??")]
    CancellationPending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancellationCompleted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aQk18tp-Ed-ak6NoX_4Aeg_288864191")]
    [Description(@"??")]
    CancellationCompleted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderCancellationStatus1CodeMetadataExtensions
{
    private static readonly OrderCancellationStatus1CodeDropdownSource _dropdownSource = new OrderCancellationStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderCancellationStatus1CodeDropdownRow GetMetadata(this OrderCancellationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

