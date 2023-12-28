﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionGroupStatus1Code.  ISO2002 ID# _YrZn49p-Ed-ak6NoX_4Aeg_-2100712417.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrZn49p-Ed-ak6NoX_4Aeg_-2100712417")]
[Description(@"Specifies the status of a group of payment transactions.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum TransactionGroupStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrZn5Np-Ed-ak6NoX_4Aeg_-2100712382")]
    [Description(@"??")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrZn5dp-Ed-ak6NoX_4Aeg_-2100712357")]
    [Description(@"??")]
    Received,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyAccepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrZn5tp-Ed-ak6NoX_4Aeg_-2100712322")]
    [Description(@"??")]
    PartiallyAccepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrZn59p-Ed-ak6NoX_4Aeg_-2100712032")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrZn6Np-Ed-ak6NoX_4Aeg_-2100712014")]
    [Description(@"??")]
    Pending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedCustomerProfile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrjY4Np-Ed-ak6NoX_4Aeg_-2100711979")]
    [Description(@"??")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedSettlementInProcess".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrjY4dp-Ed-ak6NoX_4Aeg_-2100711937")]
    [Description(@"??")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedSettlementCompleted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrjY4tp-Ed-ak6NoX_4Aeg_-2100711919")]
    [Description(@"??")]
    AcceptedSettlementCompleted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrjY49p-Ed-ak6NoX_4Aeg_-1715877559")]
    [Description(@"??")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedWithChange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YrjY5Np-Ed-ak6NoX_4Aeg_-1673394573")]
    [Description(@"??")]
    AcceptedWithChange,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionGroupStatus1CodeMetadataExtensions
{
    private static readonly TransactionGroupStatus1CodeDropdownSource _dropdownSource = new TransactionGroupStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionGroupStatus1CodeDropdownRow GetMetadata(this TransactionGroupStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

