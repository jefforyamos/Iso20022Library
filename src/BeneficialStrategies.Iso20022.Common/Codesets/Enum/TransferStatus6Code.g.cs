﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferStatus6Code.  ISO2002 ID# _zBEicLshEeiTr4dQrTCaYA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a transfer or settlement instruction status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zBEicLshEeiTr4dQrTCaYA")]
[Description(@"Specifies a transfer or settlement instruction status.")]
[DerivedFrom(typeof(TransferStatusCode))]
public enum TransferStatus6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0cRVIbshEeiTr4dQrTCaYA")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AlreadyExecuted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0i9zAbshEeiTr4dQrTCaYA")]
    [Description(@"??")]
    AlreadyExecuted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Complete".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1B6Y0bshEeiTr4dQrTCaYA")]
    [Description(@"??")]
    Complete,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Delayed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1IBA0bshEeiTr4dQrTCaYA")]
    [Description(@"??")]
    Delayed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Matched".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1kSGEbshEeiTr4dQrTCaYA")]
    [Description(@"??")]
    Matched,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1wxp8bshEeiTr4dQrTCaYA")]
    [Description(@"??")]
    Received,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SentToNextParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_59ds0bshEeiTr4dQrTCaYA")]
    [Description(@"??")]
    SentToNextParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6FfncbshEeiTr4dQrTCaYA")]
    [Description(@"??")]
    Settled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferStatus6CodeMetadataExtensions
{
    private static readonly TransferStatus6CodeDropdownSource _dropdownSource = new TransferStatus6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferStatus6CodeDropdownRow GetMetadata(this TransferStatus6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


