﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalBillingCompensationType1Code.  ISO2002 ID# _6WzSl5qlEeGSON8vddiWzQ_882310239.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of billing compensation to be applied, as published in an external billing compensation type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WzSl5qlEeGSON8vddiWzQ_882310239")]
[Description(@"Defines the type of billing compensation to be applied, as published in an external billing compensation type code list. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalBillingCompensationTypeCode))]
public enum ExternalBillingCompensationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BalanceCompensableServices".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNDAgvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BalanceCompensableServices,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ChargesAndTaxesNetDueThisStmt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNDAhfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ChargesAndTaxesNetDueThisStmt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeficitEarningsAllowanceDueThisStmt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNDAiPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DeficitEarningsAllowanceDueThisStmt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EarningsAllowance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNDAi_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    EarningsAllowance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EarningsAllowanceNetAdjustment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNDAjvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    EarningsAllowanceNetAdjustment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExcessDeficitEarningsAllowanceAdjusted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNMxgvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ExcessDeficitEarningsAllowanceAdjusted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExcessDeficitEarningsAllowance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNMxhfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ExcessDeficitEarningsAllowance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FeesPaid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNMxiPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    FeesPaid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FreeServices".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNMxi_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    FreeServices,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonBalCompensableServices".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNWigvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NonBalCompensableServices,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreviouslyChargedServices".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNWihfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PreviouslyChargedServices,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ServChargesNetAdjustBalCompensable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNWiiPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ServChargesNetAdjustBalCompensable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ServChargesNetAdjustNonBalCompensable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNWii_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ServChargesNetAdjustNonBalCompensable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ServiceChargesDueBeforeTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNWijvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ServiceChargesDueBeforeTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettleChargeTtlCurrentPeriod".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNfscvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SettleChargeTtlCurrentPeriod,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ServiceChargesDebited".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNfsdfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ServiceChargesDebited,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ServiceChargesDiscount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNfsePRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ServiceChargesDiscount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ServiceChargesInvoiced".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNfse_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ServiceChargesInvoiced,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TtlInterestCredited".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNfsfvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TtlInterestCredited,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxableServiceCharges".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNpdcvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TaxableServiceCharges,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxTotalSum".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNpddfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TaxTotalSum,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WaivedServices".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uNpdePRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    WaivedServices,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalBillingCompensationType1CodeMetadataExtensions
{
    private static readonly ExternalBillingCompensationType1CodeDropdownSource _dropdownSource = new ExternalBillingCompensationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalBillingCompensationType1CodeDropdownRow GetMetadata(this ExternalBillingCompensationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


