﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementTransactionCondition14Code.  ISO2002 ID# _RB7AOQzXEeuUZuaHWzkTew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RB7AOQzXEeuUZuaHWzkTew")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
public enum SettlementTransactionCondition14Code
{
    /// <summary>
    /// Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline.
    /// Encoded/decoded by serializers as "AcceptAfterRegularSettlementDeadline".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_RCEKGAzXEeuUZuaHWzkTew")]
    [Description(@"Settlement is on a bilaterally accepted transaction that is to be accepted beyond the regular settlement deadline.")]
    AcceptAfterRegularSettlementDeadline,
    
    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as "Assignement".
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_RB7AQQzXEeuUZuaHWzkTew")]
    [Description(@"Transfer of ownership of the asset to another party during the closing of an option.")]
    Assignement,
    
    /// <summary>
    /// Transaction is a buy to cover.
    /// Encoded/decoded by serializers as "BuytoCover".
    /// </summary>
    [EnumMember(Value = "BUTC")]
    [IsoId("_RB7AQgzXEeuUZuaHWzkTew")]
    [Description(@"Transaction is a buy to cover.")]
    BuytoCover,
    
    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as "Clean".
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_RCEKFAzXEeuUZuaHWzkTew")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    Clean,
    
    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as "DeliveryWithoutMatching".
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("_RCEKEwzXEeuUZuaHWzkTew")]
    [Description(@"Matching receipt instruction not required (only for concerned international or national central securities depositories).")]
    DeliveryWithoutMatching,
    
    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as "Dirty".
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_RB7APwzXEeuUZuaHWzkTew")]
    [Description(@"Taxable financial instruments are to be settled.")]
    Dirty,
    
    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as "Drawn".
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_RB7ARwzXEeuUZuaHWzkTew")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn,
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as "Exercised".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_RB7ARgzXEeuUZuaHWzkTew")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are exercised.")]
    Exercised,
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that have expired.
    /// Encoded/decoded by serializers as "Expired".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_RB7ASAzXEeuUZuaHWzkTew")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that have expired.")]
    Expired,
    
    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as "FreeCleanSettlement".
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("_RCEKEQzXEeuUZuaHWzkTew")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement,
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as "KnockedOut".
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_RCEKFgzXEeuUZuaHWzkTew")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are expired worthless.")]
    KnockedOut,
    
    /// <summary>
    /// No market claim should be automatically generated.
    /// Encoded/decoded by serializers as "NoAutomaticMarketClaim".
    /// </summary>
    [EnumMember(Value = "NOMC")]
    [IsoId("_RCEKFQzXEeuUZuaHWzkTew")]
    [Description(@"No market claim should be automatically generated.")]
    NoAutomaticMarketClaim,
    
    /// <summary>
    /// Security transaction is not for accounting.
    /// Encoded/decoded by serializers as "NotAccountingRelated".
    /// </summary>
    [EnumMember(Value = "NACT")]
    [IsoId("_RB7AOwzXEeuUZuaHWzkTew")]
    [Description(@"Security transaction is not for accounting.")]
    NotAccountingRelated,
    
    /// <summary>
    /// Position to cover the pending sale will be available by contractual settlement date (accounting information).
    /// Encoded/decoded by serializers as "PendingSale".
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_RCEKEgzXEeuUZuaHWzkTew")]
    [Description(@"Position to cover the pending sale will be available by contractual settlement date (accounting information).")]
    PendingSale,
    
    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as "Physical".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_RB7AQwzXEeuUZuaHWzkTew")]
    [Description(@"Securities are to be physically settled.")]
    Physical,
    
    /// <summary>
    /// Collateral position is available for other purposes (for example, onwards delivery).
    /// Encoded/decoded by serializers as "Rehypothecation".
    /// </summary>
    [EnumMember(Value = "RHYP")]
    [IsoId("_RB7APAzXEeuUZuaHWzkTew")]
    [Description(@"Collateral position is available for other purposes (for example, onwards delivery).")]
    Rehypothecation,
    
    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as "Reporting".
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_RB7ARAzXEeuUZuaHWzkTew")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting,
    
    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as "Residual".
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_RB7APQzXEeuUZuaHWzkTew")]
    [Description(@"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.")]
    Residual,
    
    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as "ShortSell".
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_RCEKFwzXEeuUZuaHWzkTew")]
    [Description(@"Account is used for short sale orders.")]
    ShortSell,
    
    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as "SpecialDelivery".
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("_RB7AQAzXEeuUZuaHWzkTew")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery,
    
    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as "SplitSettlement".
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("_RCEKEAzXEeuUZuaHWzkTew")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement,
    
    /// <summary>
    /// Transaction resulting from a transformation.
    /// Encoded/decoded by serializers as "Transformation".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_RB7APgzXEeuUZuaHWzkTew")]
    [Description(@"Transaction resulting from a transformation.")]
    Transformation,
    
    /// <summary>
    /// Securities are not be delivered but segregated following triparty collateral transaction.
    /// Encoded/decoded by serializers as "TripartySegregation".
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_RB7ARQzXEeuUZuaHWzkTew")]
    [Description(@"Securities are not be delivered but segregated following triparty collateral transaction.")]
    TripartySegregation,
    
    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as "Unexposed".
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("_RB7AOgzXEeuUZuaHWzkTew")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed,
    
    /// <summary>
    /// Identification of settlement instructions created as a result of a partial successful buy-in.
    /// Encoded/decoded by serializers as "PartialSuccessfulBuyIn".
    /// </summary>
    [EnumMember(Value = "BPSS")]
    [IsoId("_Vu5FkQzXEeuUZuaHWzkTew")]
    [Description(@"Identification of settlement instructions created as a result of a partial successful buy-in.")]
    PartialSuccessfulBuyIn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementTransactionCondition14CodeMetadataExtensions
{
    private static readonly SettlementTransactionCondition14CodeDropdownSource _dropdownSource = new SettlementTransactionCondition14CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementTransactionCondition14CodeDropdownRow GetMetadata(this SettlementTransactionCondition14Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


