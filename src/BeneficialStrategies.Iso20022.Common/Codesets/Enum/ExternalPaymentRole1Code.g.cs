﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentRole1Code.  ISO2002 ID# _ONNMYnhiEeidzqjNEfehPg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role associated with a specific party in a payment instruction, as published in an external payment role code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ONNMYnhiEeidzqjNEfehPg")]
[Description(@"Specifies the role associated with a specific party in a payment instruction, as published in an external payment role code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentRoleCode))]
public enum ExternalPaymentRole1Code
{
    /// <summary>
    /// Party responsible for managing the recovery functions related to a system.
    /// Encoded/decoded by serializers as "BKMG".
    /// </summary>
    [EnumMember(Value = "BKMG")]
    [IsoId("_umh3i_RYEeuLhpyIdtJzwg")]
    [Description(@"Party responsible for managing the recovery functions related to a system.")]
    BackupManager = ExternalPaymentRoleCode.BackupManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party in a financial institution responsible for the management of the limits. This party is responsible for fixing, modifying, or suspending limits as relevant for the management of counterpart risk or systemic risk containment.
    /// Encoded/decoded by serializers as "LMMG".
    /// </summary>
    [EnumMember(Value = "LMMG")]
    [IsoId("_umh3jvRYEeuLhpyIdtJzwg")]
    [Description(@"Party in a financial institution responsible for the management of the limits. This party is responsible for fixing, modifying, or suspending limits as relevant for the management of counterpart risk or systemic risk containment.")]
    LimitManager = ExternalPaymentRoleCode.LimitManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party in a financial institution responsible for the management of liquidity for the financial institution. This party has access to some functions available on the system, such as the liquidity transfers or management of standing instructions for liquidity control.
    /// Encoded/decoded by serializers as "LQMG".
    /// </summary>
    [EnumMember(Value = "LQMG")]
    [IsoId("_umrogvRYEeuLhpyIdtJzwg")]
    [Description(@"Party in a financial institution responsible for the management of liquidity for the financial institution. This party has access to some functions available on the system, such as the liquidity transfers or management of standing instructions for liquidity control.")]
    LiquidityManager = ExternalPaymentRoleCode.LiquidityManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party in a financial institution responsible for the management of payment processing for the financial institution. This includes authorising, recycling, and modification of payment transactions.
    /// Encoded/decoded by serializers as "PYMG".
    /// </summary>
    [EnumMember(Value = "PYMG")]
    [IsoId("_umrohfRYEeuLhpyIdtJzwg")]
    [Description(@"Party in a financial institution responsible for the management of payment processing for the financial institution. This includes authorising, recycling, and modification of payment transactions.")]
    PaymentManager = ExternalPaymentRoleCode.PaymentManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party in a financial institution entitled to obtain information from the system, but not act upon/alter this information.
    /// Encoded/decoded by serializers as "REDR".
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_um0ycvRYEeuLhpyIdtJzwg")]
    [Description(@"Party in a financial institution entitled to obtain information from the system, but not act upon/alter this information.")]
    Reader = ExternalPaymentRoleCode.Reader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party in a financial institution responsible for the management of settlement processing.
    /// Encoded/decoded by serializers as "STMG".
    /// </summary>
    [EnumMember(Value = "STMG")]
    [IsoId("_um0ydfRYEeuLhpyIdtJzwg")]
    [Description(@"Party in a financial institution responsible for the management of settlement processing.")]
    SettlementManager = ExternalPaymentRoleCode.SettlementManager, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPaymentRole1CodeMetadataExtensions
{
    private static readonly ExternalPaymentRole1CodeDropdownSource _dropdownSource = new ExternalPaymentRole1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPaymentRole1CodeDropdownRow GetMetadata(this ExternalPaymentRole1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


