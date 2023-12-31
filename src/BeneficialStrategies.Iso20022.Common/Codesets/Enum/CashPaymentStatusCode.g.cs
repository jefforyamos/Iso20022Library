﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashPaymentStatusCode.  ISO2002 ID# _a7MgQNp-Ed-ak6NoX_4Aeg_1461915358.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of a payment instruction at a specified time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7MgQNp-Ed-ak6NoX_4Aeg_1461915358")]
[Description(@"Specifies the state of a payment instruction at a specified time.")]
[Derivations(typeof(CashPaymentStatus2Code))]
// External derivations that should be provided by the proper interface are: 
public enum CashPaymentStatusCode
{
    /// <summary>
    /// The payment is awaiting settlement.
    /// Encoded/decoded by serializers as "PDNG".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_a7MgQdp-Ed-ak6NoX_4Aeg_1461915359")]
    [Description(@"The payment is awaiting settlement.")]
    Pending,
    
    /// <summary>
    /// The payment has been settled or stopped.
    /// Encoded/decoded by serializers as "FINL".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_a7MgQtp-Ed-ak6NoX_4Aeg_1461915360")]
    [Description(@"The payment has been settled or stopped.")]
    Final,
    
    /// <summary>
    /// The payment is cancelled.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_a7MgQ9p-Ed-ak6NoX_4Aeg_-167740139")]
    [Description(@"The payment is cancelled.")]
    Cancelled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashPaymentStatusCodeMetadataExtensions
{
    private static readonly CashPaymentStatusCodeDropdownSource _dropdownSource = new CashPaymentStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashPaymentStatusCodeDropdownRow GetMetadata(this CashPaymentStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


