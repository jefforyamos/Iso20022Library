﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderStatus5Code.  ISO2002 ID# _aSEqxtp-Ed-ak6NoX_4Aeg_1781619075.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aSEqxtp-Ed-ak6NoX_4Aeg_1781619075")]
[Description(@"Specifies the current status of the order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aSEqx9p-Ed-ak6NoX_4Aeg_1838875056")]
    [Description(@"??")]
    Received,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aSEqyNp-Ed-ak6NoX_4Aeg_1838874961")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AlreadyExecuted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aSN0sNp-Ed-ak6NoX_4Aeg_1838874996")]
    [Description(@"??")]
    AlreadyExecuted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SentToNextParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aSN0sdp-Ed-ak6NoX_4Aeg_1838875038")]
    [Description(@"??")]
    SentToNextParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommunicationProblemNextParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aSN0stp-Ed-ak6NoX_4Aeg_1838875133")]
    [Description(@"??")]
    CommunicationProblemNextParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aSN0s9p-Ed-ak6NoX_4Aeg_-1101289239")]
    [Description(@"??")]
    Settled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashSettledOrderNotExecuted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aSN0tNp-Ed-ak6NoX_4Aeg_-1074505844")]
    [Description(@"??")]
    CashSettledOrderNotExecuted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderStatus5CodeMetadataExtensions
{
    private static readonly OrderStatus5CodeDropdownSource _dropdownSource = new OrderStatus5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderStatus5CodeDropdownRow GetMetadata(this OrderStatus5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

