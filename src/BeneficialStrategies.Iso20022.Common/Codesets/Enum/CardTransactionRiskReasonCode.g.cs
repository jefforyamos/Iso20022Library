﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardTransactionRiskReasonCode.  ISO2002 ID# _1GyxYHsKEeSR68OJvMfxJQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason to indicate a certain level of risk for the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1GyxYHsKEeSR68OJvMfxJQ")]
[Description(@"Reason to indicate a certain level of risk for the transaction.")]
[Derivations(typeof(CardTransactionRiskReason1Code))]
public enum CardTransactionRiskReasonCode
{
    /// <summary>
    /// Suspicious sequence of approve and decline messages.
    /// Encoded/decoded by serializers as "APDL".
    /// </summary>
    [EnumMember(Value = "APDL")]
    [IsoId("_5Op-oHsKEeSR68OJvMfxJQ")]
    [Description(@"Suspicious sequence of approve and decline messages.")]
    ApproveDeclineSequence,
    
    /// <summary>
    /// Suspicious authorization activity.
    /// Encoded/decoded by serializers as "ATHA".
    /// </summary>
    [EnumMember(Value = "ATHA")]
    [IsoId("_8lU_gHsKEeSR68OJvMfxJQ")]
    [Description(@"Suspicious authorization activity.")]
    AuthorizationActivity,
    
    /// <summary>
    /// Suspicious approve or decline pattern.
    /// Encoded/decoded by serializers as "APDP".
    /// </summary>
    [EnumMember(Value = "APDP")]
    [IsoId("_TbeQ0HsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious approve or decline pattern.")]
    ApproveDeclinePattern,
    
    /// <summary>
    /// Compromised card.
    /// Encoded/decoded by serializers as "CRDC".
    /// </summary>
    [EnumMember(Value = "CRDC")]
    [IsoId("_W4E6kHsLEeSR68OJvMfxJQ")]
    [Description(@"Compromised card.")]
    CompromisedCard,
    
    /// <summary>
    /// Suspicious electronic commerce activity.
    /// Encoded/decoded by serializers as "ECMA".
    /// </summary>
    [EnumMember(Value = "ECMA")]
    [IsoId("_ZuvlsHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious electronic commerce activity.")]
    EcommerceActivity,
    
    /// <summary>
    /// Expiry date mismatch.
    /// Encoded/decoded by serializers as "EXCD".
    /// </summary>
    [EnumMember(Value = "EXCD")]
    [IsoId("_dsnwgHsLEeSR68OJvMfxJQ")]
    [Description(@"Expiry date mismatch.")]
    ExpiryDateMismatch,
    
    /// <summary>
    /// Suspicious foreign activity.
    /// Encoded/decoded by serializers as "FGNA".
    /// </summary>
    [EnumMember(Value = "FGNA")]
    [IsoId("_hl-nsHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious foreign activity.")]
    ForeignActivity,
    
    /// <summary>
    /// Suspicious geographic activity.
    /// Encoded/decoded by serializers as "GEOA".
    /// </summary>
    [EnumMember(Value = "GEOA")]
    [IsoId("_mKulQHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious geographic activity.")]
    GeographicActivity,
    
    /// <summary>
    /// High Risk MCC (Merchant Category Code).
    /// Encoded/decoded by serializers as "MCCH".
    /// </summary>
    [EnumMember(Value = "MCCH")]
    [IsoId("_pzFzEHsLEeSR68OJvMfxJQ")]
    [Description(@"High Risk MCC (Merchant Category Code).")]
    HighRiskMCC,
    
    /// <summary>
    /// Suspicious manual card data entry mode.
    /// Encoded/decoded by serializers as "KEYA".
    /// </summary>
    [EnumMember(Value = "KEYA")]
    [IsoId("_vtO2QHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious manual card data entry mode.")]
    ManualEntryActivity,
    
    /// <summary>
    /// Suspicious MCC (Merchant Category Code) activity.
    /// Encoded/decoded by serializers as "MCCA".
    /// </summary>
    [EnumMember(Value = "MCCA")]
    [IsoId("_yk4_4HsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious MCC (Merchant Category Code) activity.")]
    MerchantCategoryActivity,
    
    /// <summary>
    /// Suspicious amount.
    /// Encoded/decoded by serializers as "AMNT".
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("_5X3IgHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious amount.")]
    SuspiciousAmount,
    
    /// <summary>
    /// Suspicious fraudulent cardholder.
    /// Encoded/decoded by serializers as "CRDF".
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_78LfYHsLEeSR68OJvMfxJQ")]
    [Description(@"Suspicious fraudulent cardholder.")]
    SuspiciousFraudulentCardholder,
    
    /// <summary>
    /// Suspicious fraudulent merchant.
    /// Encoded/decoded by serializers as "MRCF".
    /// </summary>
    [EnumMember(Value = "MRCF")]
    [IsoId("_O0vg0HsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious fraudulent merchant.")]
    SuspiciousFraudulentMerchant,
    
    /// <summary>
    /// Suspicious transaction cumulated amount at merchant.
    /// Encoded/decoded by serializers as "TXCA".
    /// </summary>
    [EnumMember(Value = "TXCA")]
    [IsoId("_Xjk5MHsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction cumulated amount at merchant.")]
    TransactionCumulativeAmount,
    
    /// <summary>
    /// Suspicious transaction number at merchant.
    /// Encoded/decoded by serializers as "TXNB".
    /// </summary>
    [EnumMember(Value = "TXNB")]
    [IsoId("_bh-ocHsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction number at merchant.")]
    TransactionNumber,
    
    /// <summary>
    /// Suspicious transaction time interval.
    /// Encoded/decoded by serializers as "TMIN".
    /// </summary>
    [EnumMember(Value = "TMIN")]
    [IsoId("_eN8fcHsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction time interval.")]
    TransactionTimeIinterval,
    
    /// <summary>
    /// Suspicious transaction time.
    /// Encoded/decoded by serializers as "TXTM".
    /// </summary>
    [EnumMember(Value = "TXTM")]
    [IsoId("_hZ4P8HsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction time.")]
    TransactionTime,
    
    /// <summary>
    /// Suspicious transaction type.
    /// Encoded/decoded by serializers as "TXTP".
    /// </summary>
    [EnumMember(Value = "TXTP")]
    [IsoId("_koHGgHsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious transaction type.")]
    TransactionType,
    
    /// <summary>
    /// Suspicious unattended terminal activity.
    /// Encoded/decoded by serializers as "UATA".
    /// </summary>
    [EnumMember(Value = "UATA")]
    [IsoId("_tQX80HsMEeSR68OJvMfxJQ")]
    [Description(@"Suspicious unattended terminal activity.")]
    UnattendedActivity,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardTransactionRiskReasonCodeMetadataExtensions
{
    private static readonly CardTransactionRiskReasonCodeDropdownSource _dropdownSource = new CardTransactionRiskReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardTransactionRiskReasonCodeDropdownRow GetMetadata(this CardTransactionRiskReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


