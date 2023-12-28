﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentGroupStatus1Code.  ISO2002 ID# _v9bSwWXiEeap-P22vGV91g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment instructions, as published in an external payment group status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v9bSwWXiEeap-P22vGV91g")]
[Description(@"Specifies the status of a group of payment instructions, as published in an external payment group status code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentGroupStatusCode))]
public enum ExternalPaymentGroupStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedCustomerProfile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uW4R9fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedSettlementCompletedCreditorAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXCC8vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AcceptedSettlementCompletedCreditorAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedSettlementCompletedDebitorAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXCC9fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AcceptedSettlementCompletedDebitorAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedSettlementInProcess".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXCC-PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXCC-_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedWithChange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXLz8vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AcceptedWithChange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyAccepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXLz9fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PartiallyAccepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXU94vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Pending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXU95fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Received,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXU96PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Rejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPaymentGroupStatus1CodeMetadataExtensions
{
    private static readonly ExternalPaymentGroupStatus1CodeDropdownSource _dropdownSource = new ExternalPaymentGroupStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPaymentGroupStatus1CodeDropdownRow GetMetadata(this ExternalPaymentGroupStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

