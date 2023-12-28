﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentScenario2Code.  ISO2002 ID# _lZ0UwHYkEei7x9Ux0Cio1w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the payment scenario used for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lZ0UwHYkEei7x9Ux0Cio1w")]
[Description(@"Describes the payment scenario used for a payment transaction.")]
[DerivedFrom(typeof(PaymentScenarioCode))]
public enum PaymentScenario2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerCreditTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pmo6gXYkEei7x9Ux0Cio1w")]
    [Description(@"??")]
    CustomerCreditTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cover".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qYxiEXYkEei7x9Ux0Cio1w")]
    [Description(@"??")]
    Cover,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerCreditTransferAndCover".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rCIoIXYkEei7x9Ux0Cio1w")]
    [Description(@"??")]
    CustomerCreditTransferAndCover,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentScenario2CodeMetadataExtensions
{
    private static readonly PaymentScenario2CodeDropdownSource _dropdownSource = new PaymentScenario2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentScenario2CodeDropdownRow GetMetadata(this PaymentScenario2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


