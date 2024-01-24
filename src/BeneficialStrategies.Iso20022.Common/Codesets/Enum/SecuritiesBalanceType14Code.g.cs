﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesBalanceType14Code.  ISO2002 ID# _UNiCgIjtEeONZKAAW4pOaQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the securities or investment fund balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UNiCgIjtEeONZKAAW4pOaQ")]
[Description(@"Specifies the type of the securities or investment fund balance.")]
[DerivedFrom(typeof(SecuritiesBalanceTypeV3Code))]
public enum SecuritiesBalanceType14Code
{
    /// <summary>
    /// Balance of financial instruments that are freely available with no specific additional status.
    /// Encoded/decoded by serializers as "AWAS".
    /// </summary>
    [EnumMember(Value = "AWAS")]
    [IsoId("_ZRd2cYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that are freely available with no specific additional status.")]
    AvailableWithNoAdditionalStatus = SecuritiesBalanceTypeV3Code.AvailableWithNoAdditionalStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register.
    /// Encoded/decoded by serializers as "BTRA".
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZxKqMYjtEeONZKAAW4pOaQ")]
    [Description(@"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register.")]
    BeingTransferred = SecuritiesBalanceTypeV3Code.BeingTransferred, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// Encoded/decoded by serializers as "BLOK".
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_Z4yVIYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that are blocked.")]
    Blocked = SecuritiesBalanceTypeV3Code.Blocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are blocked for verification of authenticity.
    /// Encoded/decoded by serializers as "BLOV".
    /// </summary>
    [EnumMember(Value = "BLOV")]
    [IsoId("_aCV5wYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that are blocked for verification of authenticity.")]
    BlockedAuthenticity = SecuritiesBalanceTypeV3Code.BlockedAuthenticity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instrument blocked following a corporate action, including proxy activities.
    /// Encoded/decoded by serializers as "BLCA".
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_aNk5YYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instrument blocked following a corporate action, including proxy activities.")]
    BlockedCorporateAction = SecuritiesBalanceTypeV3Code.BlockedCorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are blocked for trading.
    /// Encoded/decoded by serializers as "BLOT".
    /// </summary>
    [EnumMember(Value = "BLOT")]
    [IsoId("_azY8MYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that are blocked for trading.")]
    BlockedTrading = SecuritiesBalanceTypeV3Code.BlockedTrading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// Encoded/decoded by serializers as "BORR".
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_a7hkgYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that have been borrowed from another party.")]
    Borrowed = SecuritiesBalanceTypeV3Code.Borrowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Net balance of financial instrument that is traded pending settlement and settlement is overdue.
    /// Encoded/decoded by serializers as "OPNT".
    /// </summary>
    [EnumMember(Value = "OPNT")]
    [IsoId("_bI2O0YjtEeONZKAAW4pOaQ")]
    [Description(@"Net balance of financial instrument that is traded pending settlement and settlement is overdue.")]
    OverdueNetPending = SecuritiesBalanceTypeV3Code.OverdueNetPending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Net balance of financial instrument that is traded pending settlement.
    /// Encoded/decoded by serializers as "PNET".
    /// </summary>
    [EnumMember(Value = "PNET")]
    [IsoId("_bPykUYjtEeONZKAAW4pOaQ")]
    [Description(@"Net balance of financial instrument that is traded pending settlement.")]
    NetPending = SecuritiesBalanceTypeV3Code.NetPending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as "COLI".
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_bZ4UcYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of securities that belong to a third party and that are held for the purpose of collateralisation.")]
    CollateralIn = SecuritiesBalanceTypeV3Code.CollateralIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as "COLO".
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_beZoEYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.")]
    CollateralOut = SecuritiesBalanceTypeV3Code.CollateralOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is used when financing is by the broker/dealer.
    /// Encoded/decoded by serializers as "MARG".
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_cfU5kYjtEeONZKAAW4pOaQ")]
    [Description(@"Account is used when financing is by the broker/dealer.")]
    DerivativesMargin = SecuritiesBalanceTypeV3Code.DerivativesMargin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as "DRAW".
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_czX28YjtEeONZKAAW4pOaQ")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn = SecuritiesBalanceTypeV3Code.Drawn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_dFBAkYjtEeONZKAAW4pOaQ")]
    [Description(@"Transaction has been generated due to transformation following a corporate action.")]
    InTransshipment = SecuritiesBalanceTypeV3Code.InTransshipment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loan for consumption.
    /// Encoded/decoded by serializers as "LOAN".
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_eE_24YjtEeONZKAAW4pOaQ")]
    [Description(@"Loan for consumption.")]
    OnLoan = SecuritiesBalanceTypeV3Code.OnLoan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// Encoded/decoded by serializers as "REGO".
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_eU7wUYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).")]
    OutForRegistration = SecuritiesBalanceTypeV3Code.OutForRegistration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a borrow transaction.
    /// Encoded/decoded by serializers as "BODE".
    /// </summary>
    [EnumMember(Value = "BODE")]
    [IsoId("_edRM8YjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that are pending delivery in relation to a borrow transaction.")]
    PendingBorrowedDelivery = SecuritiesBalanceTypeV3Code.PendingBorrowedDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a borrow transaction.
    /// Encoded/decoded by serializers as "BORE".
    /// </summary>
    [EnumMember(Value = "BORE")]
    [IsoId("_fqhDMYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that are pending receipt in relation to a borrow transaction.")]
    PendingBorrowedReceipt = SecuritiesBalanceTypeV3Code.PendingBorrowedReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instrument pending delivery following a corporate action.
    /// Encoded/decoded by serializers as "PEDA".
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_fzYrUYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instrument pending delivery following a corporate action.")]
    PendingCorporateActionDelivery = SecuritiesBalanceTypeV3Code.PendingCorporateActionDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instrument pending receipt following a corporate action.
    /// Encoded/decoded by serializers as "PECA".
    /// </summary>
    [EnumMember(Value = "PECA")]
    [IsoId("_f6RWcYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instrument pending receipt following a corporate action.")]
    PendingCorporateActionReceipt = SecuritiesBalanceTypeV3Code.PendingCorporateActionReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing has not been completed.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_gAdeAYjtEeONZKAAW4pOaQ")]
    [Description(@"Processing has not been completed.")]
    PendingDelivery = SecuritiesBalanceTypeV3Code.PendingDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery in relation to a lending transaction.
    /// Encoded/decoded by serializers as "LODE".
    /// </summary>
    [EnumMember(Value = "LODE")]
    [IsoId("_ghVWcYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that are pending delivery in relation to a lending transaction.")]
    PendingOnLoanDelivery = SecuritiesBalanceTypeV3Code.PendingOnLoanDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt in relation to a lending transaction.
    /// Encoded/decoded by serializers as "LORE".
    /// </summary>
    [EnumMember(Value = "LORE")]
    [IsoId("_gms-oYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that are pending receipt in relation to a lending transaction.")]
    PendingOnLoanReceipt = SecuritiesBalanceTypeV3Code.PendingOnLoanReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as "PENR".
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_g5EhAYjtEeONZKAAW4pOaQ")]
    [Description(@"The instruction is pending receipt of securities, for example, from a purchase, loan etc.")]
    PendingReceipt = SecuritiesBalanceTypeV3Code.PendingReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.
    /// Encoded/decoded by serializers as "PLED".
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_iLwQ4YjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of securities that belong to and is kept in the safekeeping account indicated within this message, and that are pledged.")]
    Pledged = SecuritiesBalanceTypeV3Code.Pledged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that may only be sold under certain conditions or require legal documents.
    /// Encoded/decoded by serializers as "RSTR".
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_tVrysYjtEeONZKAAW4pOaQ")]
    [Description(@"Balance of financial instruments that may only be sold under certain conditions or require legal documents.")]
    Restricted = SecuritiesBalanceTypeV3Code.Restricted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_t5MIYYjtEeONZKAAW4pOaQ")]
    [Description(@"Other. See Narrative.")]
    Unclassified = SecuritiesBalanceTypeV3Code.Unclassified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as "WDOC".
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_uReskYjtEeONZKAAW4pOaQ")]
    [Description(@"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.")]
    WaitingDocumentation = SecuritiesBalanceTypeV3Code.WaitingDocumentation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purchased investment fund units that were purchased prior to the last ex-div date.
    /// Encoded/decoded by serializers as "GRP1".
    /// </summary>
    [EnumMember(Value = "GRP1")]
    [IsoId("_An14sGK4EeWaPYQgYu-nxQ")]
    [Description(@"Purchased investment fund units that were purchased prior to the last ex-div date.|")]
    PurchasedInvestmentFundTaxGroupUnit1 = SecuritiesBalanceTypeV3Code.PurchasedInvestmentFundTaxGroupUnit1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purchased investment fund units that were purchased since the ex-div date, and that benefit from the tax exemption.
    /// Encoded/decoded by serializers as "GRP2".
    /// </summary>
    [EnumMember(Value = "GRP2")]
    [IsoId("_AtqM0WK4EeWaPYQgYu-nxQ")]
    [Description(@"Purchased investment fund units that were purchased since the ex-div date, and that benefit from the tax exemption.")]
    PurchasedInvestmentFundTaxGroupUnit2 = SecuritiesBalanceTypeV3Code.PurchasedInvestmentFundTaxGroupUnit2, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesBalanceType14CodeMetadataExtensions
{
    private static readonly SecuritiesBalanceType14CodeDropdownSource _dropdownSource = new SecuritiesBalanceType14CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesBalanceType14CodeDropdownRow GetMetadata(this SecuritiesBalanceType14Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


