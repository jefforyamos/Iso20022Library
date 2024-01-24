﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementTransactionCondition8Code.  ISO2002 ID# _nTE_cfvzEeC5cppCUzSD9A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nTE_cfvzEeC5cppCUzSD9A")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
public enum SettlementTransactionCondition8Code
{
    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as "ASGN".
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_nTE_d_vzEeC5cppCUzSD9A")]
    [Description(@"Transfer of ownership of the asset to another party during the closing of an option.")]
    Assignement = SettlementTransactionConditionCode.Assignement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a buy to cover.
    /// Encoded/decoded by serializers as "BUTC".
    /// </summary>
    [EnumMember(Value = "BUTC")]
    [IsoId("_nTE_e_vzEeC5cppCUzSD9A")]
    [Description(@"Transaction is a buy to cover.")]
    BuytoCover = SettlementTransactionConditionCode.BuytoCover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as "CLEN".
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_nTE_f_vzEeC5cppCUzSD9A")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    Clean = SettlementTransactionConditionCode.Clean, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as "DIRT".
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_nTE_g_vzEeC5cppCUzSD9A")]
    [Description(@"Taxable financial instruments are to be settled.")]
    Dirty = SettlementTransactionConditionCode.Dirty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as "DLWM".
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("_nTE_h_vzEeC5cppCUzSD9A")]
    [Description(@"Matching receipt instruction not required (only for concerned international or national central securities depositories).")]
    DeliveryWithoutMatching = SettlementTransactionConditionCode.DeliveryWithoutMatching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as "DRAW".
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_nTE_i_vzEeC5cppCUzSD9A")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SettlementTransactionConditionCode.Drawn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as "EXER".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_nTE_j_vzEeC5cppCUzSD9A")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are exercised.")]
    Exercised = SettlementTransactionConditionCode.Exercised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as "FRCL".
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("_nTE_k_vzEeC5cppCUzSD9A")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement = SettlementTransactionConditionCode.FreeCleanSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as "KNOC".
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_nTE_l_vzEeC5cppCUzSD9A")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are expired worthless.")]
    KnockedOut = SettlementTransactionConditionCode.KnockedOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_nTE_m_vzEeC5cppCUzSD9A")]
    [Description(@"Securities are to be physically settled.")]
    Physical = SettlementTransactionConditionCode.Physical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as "RESI".
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_nTE_n_vzEeC5cppCUzSD9A")]
    [Description(@"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.")]
    Residual = SettlementTransactionConditionCode.Residual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as "SHOR".
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_nTE_o_vzEeC5cppCUzSD9A")]
    [Description(@"Account is used for short sale orders.")]
    ShortSell = SettlementTransactionConditionCode.ShortSell, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as "SPDL".
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("_nTE_p_vzEeC5cppCUzSD9A")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery = SettlementTransactionConditionCode.SpecialDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as "SPST".
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("_nTE_q_vzEeC5cppCUzSD9A")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement = SettlementTransactionConditionCode.SplitSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that have expired.
    /// Encoded/decoded by serializers as "EXPI".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_nTE_r_vzEeC5cppCUzSD9A")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that have expired.")]
    Expired = SettlementTransactionConditionCode.Expired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Position to cover the pending sale will be available by contractual settlement date (accounting information).
    /// Encoded/decoded by serializers as "PENS".
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_nTE_s_vzEeC5cppCUzSD9A")]
    [Description(@"Position to cover the pending sale will be available by contractual settlement date (accounting information).")]
    PendingSale = SettlementTransactionConditionCode.PendingSale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as "UNEX".
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("_nTE_t_vzEeC5cppCUzSD9A")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed = SettlementTransactionConditionCode.Unexposed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities are not be delivered but segregated following triparty collateral transaction.
    /// Encoded/decoded by serializers as "TRIP".
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_nTE_u_vzEeC5cppCUzSD9A")]
    [Description(@"Securities are not be delivered but segregated following triparty collateral transaction.")]
    TripartySegregation = SettlementTransactionConditionCode.TripartySegregation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No market claim should be automatically generated.
    /// Encoded/decoded by serializers as "NOMC".
    /// </summary>
    [EnumMember(Value = "NOMC")]
    [IsoId("_nTE_v_vzEeC5cppCUzSD9A")]
    [Description(@"No market claim should be automatically generated.")]
    NoAutomaticMarketClaim = SettlementTransactionConditionCode.NoAutomaticMarketClaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction resulting from a transformation.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_nTE_w_vzEeC5cppCUzSD9A")]
    [Description(@"Transaction resulting from a transformation.")]
    Transformation = SettlementTransactionConditionCode.Transformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collateral position is available for other purposes (for example, onwards delivery).
    /// Encoded/decoded by serializers as "RHYP".
    /// </summary>
    [EnumMember(Value = "RHYP")]
    [IsoId("_nTE_x_vzEeC5cppCUzSD9A")]
    [Description(@"Collateral position is available for other purposes (for example, onwards delivery).")]
    Rehypothecation = SettlementTransactionConditionCode.Rehypothecation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_nTE_y_vzEeC5cppCUzSD9A")]
    [Description(@"Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline.")]
    AcceptAfterRegularSettlementDeadline = SettlementTransactionConditionCode.AcceptAfterRegularSettlementDeadline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as "RPTO".
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_AH6Dbv8HEeCfYPzkgpDStA")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting = SettlementTransactionConditionCode.Reporting, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementTransactionCondition8CodeMetadataExtensions
{
    private static readonly SettlementTransactionCondition8CodeDropdownSource _dropdownSource = new SettlementTransactionCondition8CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementTransactionCondition8CodeDropdownRow GetMetadata(this SettlementTransactionCondition8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


