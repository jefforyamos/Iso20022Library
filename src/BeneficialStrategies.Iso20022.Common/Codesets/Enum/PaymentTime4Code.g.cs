﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentTime4Code.  ISO2002 ID# _vla3MBVeEeOrY9qSHVspCA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the payment conditions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vla3MBVeEeOrY9qSHVspCA")]
[Description(@"Specifies the payment conditions.")]
[DerivedFrom(typeof(PaymentTimeCode))]
public enum PaymentTime4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentOnReceiptOfInvoice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_w_H1ERVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    PaymentOnReceiptOfInvoice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentOnDelivery".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xGRl8RVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    PaymentOnDelivery,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfPeriodAfterShipmentDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xPEVkRVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfPeriodAfterShipmentDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfPeriodAfterReceipt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xYA2MRVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfPeriodAfterReceipt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfPeriodAfterPurchaseOrderDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xgDX4RVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfPeriodAfterPurchaseOrderDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfPeriodAfterInvoiceDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xqyBMRVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfPeriodAfterInvoiceDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfPeriodAfterEndOfReceiptMonth".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_x1EloRVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfPeriodAfterEndOfReceiptMonth,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfPeriodAfterEndOfDeliveryMonth".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_x8OWgRVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfPeriodAfterEndOfDeliveryMonth,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfPeriodAfterDelivery".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yDYHYRVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfPeriodAfterDelivery,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfPeriodAfterBaselineEstablishment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yKOWQRVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfPeriodAfterBaselineEstablishment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfMonthOfReceipt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yRO9MRVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfMonthOfReceipt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfMonthOfDelivery".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yYFMERVeEeOrY9qSHVspCA")]
    [Description(@"??")]
    EndOfMonthOfDelivery,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentTime4CodeMetadataExtensions
{
    private static readonly PaymentTime4CodeDropdownSource _dropdownSource = new PaymentTime4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentTime4CodeDropdownRow GetMetadata(this PaymentTime4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

