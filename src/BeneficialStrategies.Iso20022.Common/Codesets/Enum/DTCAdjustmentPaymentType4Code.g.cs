﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCAdjustmentPaymentType4Code.  ISO2002 ID# _2g6-gMMNEee-Vv_OVx0uAQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2g6-gMMNEee-Vv_OVx0uAQ")]
[Description(@"Specifies the type of the payment adjustment.")]
[DerivedFrom(typeof(DTCAdjustmentPaymentTypeV3Code))]
public enum DTCAdjustmentPaymentType4Code
{
    /// <summary>
    /// Adjusted for rights subscription related adjustment.
    /// Encoded/decoded by serializers as "RRRA".
    /// </summary>
    [EnumMember(Value = "RRRA")]
    [IsoId("_F2YFkcMOEee-Vv_OVx0uAQ")]
    [Description(@"Adjusted for rights subscription related adjustment.")]
    AdjustedForRightsSubscription = DTCAdjustmentPaymentTypeV3Code.AdjustedForRightsSubscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// American Depository Receipt issue fee charge adjustment.
    /// Encoded/decoded by serializers as "RADC".
    /// </summary>
    [EnumMember(Value = "RADC")]
    [IsoId("_F7vGscMOEee-Vv_OVx0uAQ")]
    [Description(@"American Depository Receipt issue fee charge adjustment.")]
    ADRIssueFeeCharge = DTCAdjustmentPaymentTypeV3Code.ADRIssueFeeCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ADR issue fee reversal adjustment.
    /// Encoded/decoded by serializers as "RADR".
    /// </summary>
    [EnumMember(Value = "RADR")]
    [IsoId("_F9rAYcMOEee-Vv_OVx0uAQ")]
    [Description(@"ADR issue fee reversal adjustment.")]
    ADRIssueFeeReversal = DTCAdjustmentPaymentTypeV3Code.ADRIssueFeeReversal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash in lieu related adjustment.
    /// Encoded/decoded by serializers as "RCIL".
    /// </summary>
    [EnumMember(Value = "RCIL")]
    [IsoId("_GCufgcMOEee-Vv_OVx0uAQ")]
    [Description(@"Cash in lieu related adjustment.")]
    CashInLieu = DTCAdjustmentPaymentTypeV3Code.CashInLieu, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Claim settlement related adjustment.
    /// Encoded/decoded by serializers as "RRCL".
    /// </summary>
    [EnumMember(Value = "RRCL")]
    [IsoId("_GH7vocMOEee-Vv_OVx0uAQ")]
    [Description(@"Claim settlement related adjustment.")]
    ClaimSettlement = DTCAdjustmentPaymentTypeV3Code.ClaimSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend payment on a DTC custody held security related adjustment.
    /// Encoded/decoded by serializers as "RCDP".
    /// </summary>
    [EnumMember(Value = "RCDP")]
    [IsoId("_GJt4UcMOEee-Vv_OVx0uAQ")]
    [Description(@"Dividend payment on a DTC custody held security related adjustment.")]
    CustodyDividendPayment = DTCAdjustmentPaymentTypeV3Code.CustodyDividendPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custody reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRCD".
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_GOx-gcMOEee-Vv_OVx0uAQ")]
    [Description(@"Custody reorganisation deposit related adjustment.")]
    CustodyReorganisationDeposit = DTCAdjustmentPaymentTypeV3Code.CustodyReorganisationDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dynamic rate change related adjustment.
    /// Encoded/decoded by serializers as "RRDR".
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_GarsgcMOEee-Vv_OVx0uAQ")]
    [Description(@"Dynamic rate change related adjustment.")]
    DynamicRateChange = DTCAdjustmentPaymentTypeV3Code.DynamicRateChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_GcUEMcMOEee-Vv_OVx0uAQ")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailSettlement = DTCAdjustmentPaymentTypeV3Code.FailSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fail tracking tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXF".
    /// </summary>
    [EnumMember(Value = "TJXF")]
    [IsoId("_GhhUUcMOEee-Vv_OVx0uAQ")]
    [Description(@"Fail tracking tax withholding related adjustment.")]
    FailTrackingTaxWithholding = DTCAdjustmentPaymentTypeV3Code.FailTrackingTaxWithholding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Last day protect related adjustment.
    /// Encoded/decoded by serializers as "RRRL".
    /// </summary>
    [EnumMember(Value = "RRRL")]
    [IsoId("_GuKpMcMOEee-Vv_OVx0uAQ")]
    [Description(@"Last day protect related adjustment.")]
    LastDayProtect = DTCAdjustmentPaymentTypeV3Code.LastDayProtect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandatory legal reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRLR".
    /// </summary>
    [EnumMember(Value = "RRLR")]
    [IsoId("_GzE-YcMOEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory legal reorganisation deposit related adjustment.")]
    MandatoryLegalReorganisationDeposit = DTCAdjustmentPaymentTypeV3Code.MandatoryLegalReorganisationDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandatory over three year reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRR3".
    /// </summary>
    [EnumMember(Value = "RRR3")]
    [IsoId("_G0t9IcMOEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory over three year reorganisation deposit related adjustment.")]
    MandatoryOverThreeYearReorganisationDeposit = DTCAdjustmentPaymentTypeV3Code.MandatoryOverThreeYearReorganisationDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual user tax adjustment.
    /// Encoded/decoded by serializers as "TJXU".
    /// </summary>
    [EnumMember(Value = "TJXU")]
    [IsoId("_G5xcQcMOEee-Vv_OVx0uAQ")]
    [Description(@"Manual user tax adjustment.")]
    ManualUserTax = DTCAdjustmentPaymentTypeV3Code.ManualUserTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as "MISC".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_G7abAcMOEee-Vv_OVx0uAQ")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousSettlement = DTCAdjustmentPaymentTypeV3Code.MiscellaneousSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_HOAm4cMOEee-Vv_OVx0uAQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other = DTCAdjustmentPaymentTypeV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reclassification tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXD".
    /// </summary>
    [EnumMember(Value = "TJXD")]
    [IsoId("_HZwj4cMOEee-Vv_OVx0uAQ")]
    [Description(@"Reclassification tax withholding related adjustment.")]
    ReclassificationTaxWithholding = DTCAdjustmentPaymentTypeV3Code.ReclassificationTaxWithholding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as "RRD1".
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_HbZiocMOEee-Vv_OVx0uAQ")]
    [Description(@"Participant deposited a security within 10 days after a corporate action event has occurred.")]
    ReorganisationDepositPhaseOne = DTCAdjustmentPaymentTypeV3Code.ReorganisationDepositPhaseOne, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as "RRD2".
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_HdB6UcMOEee-Vv_OVx0uAQ")]
    [Description(@"Participant deposited a security 10 days after a corporate action event has occurred.")]
    ReorganisationDepositPhaseTwo = DTCAdjustmentPaymentTypeV3Code.ReorganisationDepositPhaseTwo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal related adjustment.
    /// Encoded/decoded by serializers as "REVA".
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("_Hh8PgcMOEee-Vv_OVx0uAQ")]
    [Description(@"Reversal related adjustment.")]
    Reversal = DTCAdjustmentPaymentTypeV3Code.Reversal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXR".
    /// </summary>
    [EnumMember(Value = "TJXR")]
    [IsoId("_HjlOQcMOEee-Vv_OVx0uAQ")]
    [Description(@"Reversal of tax withholding related adjustment.")]
    ReversalOfTaxWithholding = DTCAdjustmentPaymentTypeV3Code.ReversalOfTaxWithholding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intra-day reversal of original tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXV".
    /// </summary>
    [EnumMember(Value = "TJXV")]
    [IsoId("_H1k9McMOEee-Vv_OVx0uAQ")]
    [Description(@"Intra-day reversal of original tax withholding related adjustment.")]
    IntraDayReversalOfOriginalTaxWithholding = DTCAdjustmentPaymentTypeV3Code.IntraDayReversalOfOriginalTaxWithholding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRML".
    /// </summary>
    [EnumMember(Value = "RRML")]
    [IsoId("_H-DjwcMOEee-Vv_OVx0uAQ")]
    [Description(@"Legal reorganisation deposit related adjustment.")]
    LegalReorganisationDeposits = DTCAdjustmentPaymentTypeV3Code.LegalReorganisationDeposits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandatory reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRMD".
    /// </summary>
    [EnumMember(Value = "RRMD")]
    [IsoId("_IGixYcMOEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory reorganisation deposit related adjustment.")]
    MandatoryReorganisationDeposit = DTCAdjustmentPaymentTypeV3Code.MandatoryReorganisationDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original (initial) tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXO".
    /// </summary>
    [EnumMember(Value = "TJXO")]
    [IsoId("_ILcfgcMOEee-Vv_OVx0uAQ")]
    [Description(@"Original (initial) tax withholding related adjustment.")]
    OriginalInitialTaxWithholding = DTCAdjustmentPaymentTypeV3Code.OriginalInitialTaxWithholding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original late tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXL".
    /// </summary>
    [EnumMember(Value = "TJXL")]
    [IsoId("_IQNqwcMOEee-Vv_OVx0uAQ")]
    [Description(@"Original late tax withholding related adjustment.")]
    OriginalLateTaxWithholding = DTCAdjustmentPaymentTypeV3Code.OriginalLateTaxWithholding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate change tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXT".
    /// </summary>
    [EnumMember(Value = "TJXT")]
    [IsoId("_IYPlYcMOEee-Vv_OVx0uAQ")]
    [Description(@"Rate change tax withholding related adjustment.")]
    RateChangeTaxWithholding = DTCAdjustmentPaymentTypeV3Code.RateChangeTaxWithholding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_IgRgAcMOEee-Vv_OVx0uAQ")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoSettlement = DTCAdjustmentPaymentTypeV3Code.RepoSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights protect related adjustment.
    /// Encoded/decoded by serializers as "RRRI".
    /// </summary>
    [EnumMember(Value = "RRRI")]
    [IsoId("_JKrH4cMOEee-Vv_OVx0uAQ")]
    [Description(@"Rights protect related adjustment.")]
    RightsProtect = DTCAdjustmentPaymentTypeV3Code.RightsProtect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights sales related adjustment.
    /// Encoded/decoded by serializers as "RRRS".
    /// </summary>
    [EnumMember(Value = "RRRS")]
    [IsoId("_JPldEcMOEee-Vv_OVx0uAQ")]
    [Description(@"Rights sales related adjustment.")]
    RightsSales = DTCAdjustmentPaymentTypeV3Code.RightsSales, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights step up related adjustment.
    /// Encoded/decoded by serializers as "RRRU".
    /// </summary>
    [EnumMember(Value = "RRRU")]
    [IsoId("_JUWBQcMOEee-Vv_OVx0uAQ")]
    [Description(@"Rights step up related adjustment.")]
    RightsStepUp = DTCAdjustmentPaymentTypeV3Code.RightsStepUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights subscription related adjustment.
    /// Encoded/decoded by serializers as "RRRE".
    /// </summary>
    [EnumMember(Value = "RRRE")]
    [IsoId("_JZHMgcMOEee-Vv_OVx0uAQ")]
    [Description(@"Rights subscription related adjustment.")]
    RightsSubscription = DTCAdjustmentPaymentTypeV3Code.RightsSubscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as "STOK".
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_JeKrocMOEee-Vv_OVx0uAQ")]
    [Description(@"Stock loan transaction.")]
    StockLoanSettlement = DTCAdjustmentPaymentTypeV3Code.StockLoanSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax instruction change related adjustment.
    /// Encoded/decoded by serializers as "TJXI".
    /// </summary>
    [EnumMember(Value = "TJXI")]
    [IsoId("_JjOKwcMOEee-Vv_OVx0uAQ")]
    [Description(@"Tax instruction change related adjustment.")]
    TaxInstructionChange = DTCAdjustmentPaymentTypeV3Code.TaxInstructionChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tender offer fraction related adjustment.
    /// Encoded/decoded by serializers as "RRT2".
    /// </summary>
    [EnumMember(Value = "RRT2")]
    [IsoId("_Jn_WAcMOEee-Vv_OVx0uAQ")]
    [Description(@"Tender offer fraction related adjustment.")]
    TenderOfferFraction = DTCAdjustmentPaymentTypeV3Code.TenderOfferFraction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Warrant Participant delete related adjustment.
    /// Encoded/decoded by serializers as "RRWT".
    /// </summary>
    [EnumMember(Value = "RRWT")]
    [IsoId("_JpntscMOEee-Vv_OVx0uAQ")]
    [Description(@"Warrant Participant delete related adjustment.")]
    WarrantParticipantDelete = DTCAdjustmentPaymentTypeV3Code.WarrantParticipantDelete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Warrant rate change related adjustment.
    /// Encoded/decoded by serializers as "RRWC".
    /// </summary>
    [EnumMember(Value = "RRWC")]
    [IsoId("_JuYR4cMOEee-Vv_OVx0uAQ")]
    [Description(@"Warrant rate change related adjustment.")]
    WarrantRateChange = DTCAdjustmentPaymentTypeV3Code.WarrantRateChange, // same ordinal as derivation source for type conversions
    
}
