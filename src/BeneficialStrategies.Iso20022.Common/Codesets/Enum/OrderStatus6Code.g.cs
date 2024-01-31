﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderStatus6Code.  ISO2002 ID# _aSN0tdp-Ed-ak6NoX_4Aeg_187563892.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies current status of order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aSN0tdp-Ed-ak6NoX_4Aeg_187563892")]
[Description(@"Identifies current status of order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus6Code
{
    /// <summary>
    /// Order has been partially filled, and is done for the day, ie, no further executions will take place today.
    /// Encoded/decoded by serializers as "DONE".
    /// </summary>
    [EnumMember(Value = "DONE")]
    [IsoId("_aSN0ttp-Ed-ak6NoX_4Aeg_300233698")]
    [Description(@"Order has been partially filled, and is done for the day, ie, no further executions will take place today.")]
    DoneForDay = OrderStatusCode.DoneForDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order has been rejected by sell-side. NOTE: An order can be rejected subsequent to order acknowledgment, i.e. an order can pass from New to Rejected status.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_aSN0t9p-Ed-ak6NoX_4Aeg_303929674")]
    [Description(@"Order has been rejected by sell-side. NOTE: An order can be rejected subsequent to order acknowledgment, i.e. an order can pass from New to Rejected status.")]
    Rejected = OrderStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that a list has been received and the sell side is working it.
    /// Encoded/decoded by serializers as "EXEC".
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_aSN0uNp-Ed-ak6NoX_4Aeg_316855927")]
    [Description(@"Indicates that a list has been received and the sell side is working it.")]
    Executing = OrderStatusCode.Executing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that a cancellation request has been received and the sell side is in the process of pulling any orders that were being worked. The status of individual order can be found out from the detail repeating group.
    /// Encoded/decoded by serializers as "CACE".
    /// </summary>
    [EnumMember(Value = "CACE")]
    [IsoId("_aSXlsNp-Ed-ak6NoX_4Aeg_316855987")]
    [Description(@"Indicates that a cancellation request has been received and the sell side is in the process of pulling any orders that were being worked. The status of individual order can be found out from the detail repeating group.")]
    Cancelling = OrderStatusCode.Cancelling, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used whenever any of the individual orders have a status that requires something to be done. For instance, an alert would be used when a buy-side firm has submitted a list that has individual stock reject that have not been addressed.
    /// Encoded/decoded by serializers as "ALER".
    /// </summary>
    [EnumMember(Value = "ALER")]
    [IsoId("_aSXlsdp-Ed-ak6NoX_4Aeg_316856039")]
    [Description(@"Used whenever any of the individual orders have a status that requires something to be done. For instance, an alert would be used when a buy-side firm has submitted a list that has individual stock reject that have not been addressed.")]
    Alert = OrderStatusCode.Alert, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is accepted and is ready for execution (execution is the moment when pricing is applied).
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aSXlstp-Ed-ak6NoX_4Aeg_335327371")]
    [Description(@"Order is accepted and is ready for execution (execution is the moment when pricing is applied).")]
    Accepted = OrderStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order has been received and is being evaluated for pricing.
    /// Encoded/decoded by serializers as "ACBI".
    /// </summary>
    [EnumMember(Value = "ACBI")]
    [IsoId("_aSXls9p-Ed-ak6NoX_4Aeg_346411498")]
    [Description(@"Order has been received and is being evaluated for pricing.")]
    AcceptedForBidding = OrderStatusCode.AcceptedForBidding, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderStatus6CodeMetadataExtensions
{
    private static readonly OrderStatus6CodeDropdownSource _dropdownSource = new OrderStatus6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderStatus6CodeDropdownRow GetMetadata(this OrderStatus6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


