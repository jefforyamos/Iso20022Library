﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationProcessingStatus1Code.  ISO2002 ID# _bXgo0tp-Ed-ak6NoX_4Aeg_2094579534.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXgo0tp-Ed-ak6NoX_4Aeg_2094579534")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(CancellationProcessingStatusCode))]
public enum CancellationProcessingStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancellationCompleted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXgo09p-Ed-ak6NoX_4Aeg_2094579543")]
    [Description(@"??")]
    CancellationCompleted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingCancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXgo1Np-Ed-ak6NoX_4Aeg_2094579544")]
    [Description(@"??")]
    PendingCancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Denied".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXgo1dp-Ed-ak6NoX_4Aeg_2094579564")]
    [Description(@"??")]
    Denied,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivedAtStockExchange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXgo1tp-Ed-ak6NoX_4Aeg_2094579565")]
    [Description(@"??")]
    ReceivedAtStockExchange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivedAtIntermediary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXgo19p-Ed-ak6NoX_4Aeg_2094579595")]
    [Description(@"??")]
    ReceivedAtIntermediary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXqZ0Np-Ed-ak6NoX_4Aeg_2094579596")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyFilled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXqZ0dp-Ed-ak6NoX_4Aeg_2094579626")]
    [Description(@"??")]
    PartiallyFilled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXqZ0tp-Ed-ak6NoX_4Aeg_2094579627")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InRepair".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXqZ09p-Ed-ak6NoX_4Aeg_2094579656")]
    [Description(@"??")]
    InRepair,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationProcessingStatus1CodeMetadataExtensions
{
    private static readonly CancellationProcessingStatus1CodeDropdownSource _dropdownSource = new CancellationProcessingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationProcessingStatus1CodeDropdownRow GetMetadata(this CancellationProcessingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

