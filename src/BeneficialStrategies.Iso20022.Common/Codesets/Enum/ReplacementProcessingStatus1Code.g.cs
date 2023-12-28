﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReplacementProcessingStatus1Code.  ISO2002 ID# _ZwPwF9p-Ed-ak6NoX_4Aeg_-1450819640.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status of the replacement request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZwPwF9p-Ed-ak6NoX_4Aeg_-1450819640")]
[Description(@"Specifies the processing status of the replacement request.")]
[DerivedFrom(typeof(ReplacementProcessingStatusCode))]
public enum ReplacementProcessingStatus1Code
{
    /// <summary>
    /// Replacement request cannot be executed.
    /// Encoded/decoded by serializers as "Denied".
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZwPwGNp-Ed-ak6NoX_4Aeg_-1450819609")]
    [Description(@"Replacement request cannot be executed.")]
    Denied,
    
    /// <summary>
    /// Replacement request previously received from you has been received at the stock exchange.
    /// Encoded/decoded by serializers as "ReceivedAtStockExchange".
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_ZwPwGdp-Ed-ak6NoX_4Aeg_-1450819608")]
    [Description(@"Replacement request previously received from you has been received at the stock exchange.")]
    ReceivedAtStockExchange,
    
    /// <summary>
    /// Replacement request previously received from you has been received at intermediary (if not stock exchange).
    /// Encoded/decoded by serializers as "ReceivedAtIntermediary".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZwY6ANp-Ed-ak6NoX_4Aeg_-1450819607")]
    [Description(@"Replacement request previously received from you has been received at intermediary (if not stock exchange).")]
    ReceivedAtIntermediary,
    
    /// <summary>
    /// Replacement request has been accepted for further processing by the account servicer (technical receipt).
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZwY6Adp-Ed-ak6NoX_4Aeg_-1450819587")]
    [Description(@"Replacement request has been accepted for further processing by the account servicer (technical receipt).")]
    Accepted,
    
    /// <summary>
    /// Order is partially filled, replacement processing accepted for the remaining.
    /// Encoded/decoded by serializers as "PartialReplacementAccepted".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZwY6Atp-Ed-ak6NoX_4Aeg_-1450819578")]
    [Description(@"Order is partially filled, replacement processing accepted for the remaining.")]
    PartialReplacementAccepted,
    
    /// <summary>
    /// Replacement request is pending.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZwY6A9p-Ed-ak6NoX_4Aeg_-1450819556")]
    [Description(@"Replacement request is pending.")]
    Pending,
    
    /// <summary>
    /// Replacement request has been rejected for further processing.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZwY6BNp-Ed-ak6NoX_4Aeg_-1450819547")]
    [Description(@"Replacement request has been rejected for further processing.")]
    Rejected,
    
    /// <summary>
    /// Replacement request has been completed.
    /// Encoded/decoded by serializers as "Completed".
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_ZwY6Bdp-Ed-ak6NoX_4Aeg_-1450819525")]
    [Description(@"Replacement request has been completed.")]
    Completed,
    
    /// <summary>
    /// Replacement request previously received from you is in repair.
    /// Encoded/decoded by serializers as "InRepair".
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_ZwY6Btp-Ed-ak6NoX_4Aeg_-1450819516")]
    [Description(@"Replacement request previously received from you is in repair.")]
    InRepair,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReplacementProcessingStatus1CodeMetadataExtensions
{
    private static readonly ReplacementProcessingStatus1CodeDropdownSource _dropdownSource = new ReplacementProcessingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReplacementProcessingStatus1CodeDropdownRow GetMetadata(this ReplacementProcessingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


