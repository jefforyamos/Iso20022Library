﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCAdjustmentPaymentTypeV3Code.  ISO2002 ID# _vYTypsMMEee-Vv_OVx0uAQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vYTypsMMEee-Vv_OVx0uAQ")]
[Description(@"Specifies the type of the payment adjustment.")]
[Derivations(typeof(DTCAdjustmentPaymentType5Code),typeof(DTCAdjustmentPaymentType4Code))]
// External derivations that should be provided by the proper interface are: 
public enum DTCAdjustmentPaymentTypeV3Code
{
    /// <summary>
    /// Adjusted for rights subscription related adjustment.
    /// Encoded/decoded by serializers as "RRRA".
    /// </summary>
    [EnumMember(Value = "RRRA")]
    [IsoId("_vYdjjsMMEee-Vv_OVx0uAQ")]
    [Description(@"Adjusted for rights subscription related adjustment.")]
    AdjustedForRightsSubscription,
    
    /// <summary>
    /// American Depository Receipt issue fee charge adjustment.
    /// Encoded/decoded by serializers as "RADC".
    /// </summary>
    [EnumMember(Value = "RADC")]
    [IsoId("_vYdjjMMMEee-Vv_OVx0uAQ")]
    [Description(@"American Depository Receipt issue fee charge adjustment.")]
    ADRIssueFeeCharge,
    
    /// <summary>
    /// ADR issue fee reversal adjustment.
    /// Encoded/decoded by serializers as "RADR".
    /// </summary>
    [EnumMember(Value = "RADR")]
    [IsoId("_vYTyuMMMEee-Vv_OVx0uAQ")]
    [Description(@"ADR issue fee reversal adjustment.")]
    ADRIssueFeeReversal,
    
    /// <summary>
    /// Cash in lieu related adjustment.
    /// Encoded/decoded by serializers as "RCIL".
    /// </summary>
    [EnumMember(Value = "RCIL")]
    [IsoId("_vYdjicMMEee-Vv_OVx0uAQ")]
    [Description(@"Cash in lieu related adjustment.")]
    CashInLieu,
    
    /// <summary>
    /// Claim settlement related adjustment.
    /// Encoded/decoded by serializers as "RRCL".
    /// </summary>
    [EnumMember(Value = "RRCL")]
    [IsoId("_vYdjgcMMEee-Vv_OVx0uAQ")]
    [Description(@"Claim settlement related adjustment.")]
    ClaimSettlement,
    
    /// <summary>
    /// Dividend payment on a DTC custody held security related adjustment.
    /// Encoded/decoded by serializers as "RCDP".
    /// </summary>
    [EnumMember(Value = "RCDP")]
    [IsoId("_vYTyucMMEee-Vv_OVx0uAQ")]
    [Description(@"Dividend payment on a DTC custody held security related adjustment.")]
    CustodyDividendPayment,
    
    /// <summary>
    /// Custody reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRCD".
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_vYdjisMMEee-Vv_OVx0uAQ")]
    [Description(@"Custody reorganisation deposit related adjustment.")]
    CustodyReorganisationDeposit,
    
    /// <summary>
    /// Dynamic rate change related adjustment.
    /// Encoded/decoded by serializers as "RRDR".
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_vYTys8MMEee-Vv_OVx0uAQ")]
    [Description(@"Dynamic rate change related adjustment.")]
    DynamicRateChange,
    
    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_vYdjgsMMEee-Vv_OVx0uAQ")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailSettlement,
    
    /// <summary>
    /// Fail tracking tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXF".
    /// </summary>
    [EnumMember(Value = "TJXF")]
    [IsoId("_vYTyrsMMEee-Vv_OVx0uAQ")]
    [Description(@"Fail tracking tax withholding related adjustment.")]
    FailTrackingTaxWithholding,
    
    /// <summary>
    /// Intra-day reversal of original tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXV".
    /// </summary>
    [EnumMember(Value = "TJXV")]
    [IsoId("_vYTytsMMEee-Vv_OVx0uAQ")]
    [Description(@"Intra-day reversal of original tax withholding related adjustment.")]
    IntraDayReversalOfOriginalTaxWithholding,
    
    /// <summary>
    /// Last day protect related adjustment.
    /// Encoded/decoded by serializers as "RRRL".
    /// </summary>
    [EnumMember(Value = "RRRL")]
    [IsoId("_vYTyqMMMEee-Vv_OVx0uAQ")]
    [Description(@"Last day protect related adjustment.")]
    LastDayProtect,
    
    /// <summary>
    /// Legal reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRML".
    /// </summary>
    [EnumMember(Value = "RRML")]
    [IsoId("_vYdjj8MMEee-Vv_OVx0uAQ")]
    [Description(@"Legal reorganisation deposit related adjustment.")]
    LegalReorganisationDeposits,
    
    /// <summary>
    /// Mandatory legal reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRLR".
    /// </summary>
    [EnumMember(Value = "RRLR")]
    [IsoId("_vYTyrcMMEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory legal reorganisation deposit related adjustment.")]
    MandatoryLegalReorganisationDeposit,
    
    /// <summary>
    /// Mandatory over three year reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRR3".
    /// </summary>
    [EnumMember(Value = "RRR3")]
    [IsoId("_vYdji8MMEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory over three year reorganisation deposit related adjustment.")]
    MandatoryOverThreeYearReorganisationDeposit,
    
    /// <summary>
    /// Mandatory reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as "RRMD".
    /// </summary>
    [EnumMember(Value = "RRMD")]
    [IsoId("_vYTyr8MMEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory reorganisation deposit related adjustment.")]
    MandatoryReorganisationDeposit,
    
    /// <summary>
    /// Manual user tax adjustment.
    /// Encoded/decoded by serializers as "TJXU".
    /// </summary>
    [EnumMember(Value = "TJXU")]
    [IsoId("_vYTytMMMEee-Vv_OVx0uAQ")]
    [Description(@"Manual user tax adjustment.")]
    ManualUserTax,
    
    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as "MISC".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_vYdjjcMMEee-Vv_OVx0uAQ")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousSettlement,
    
    /// <summary>
    /// Original (initial) tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXO".
    /// </summary>
    [EnumMember(Value = "TJXO")]
    [IsoId("_vYdjhMMMEee-Vv_OVx0uAQ")]
    [Description(@"Original (initial) tax withholding related adjustment.")]
    OriginalInitialTaxWithholding,
    
    /// <summary>
    /// Original late tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXL".
    /// </summary>
    [EnumMember(Value = "TJXL")]
    [IsoId("_vYTysMMMEee-Vv_OVx0uAQ")]
    [Description(@"Original late tax withholding related adjustment.")]
    OriginalLateTaxWithholding,
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_vYdjg8MMEee-Vv_OVx0uAQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,
    
    /// <summary>
    /// Rate change tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXT".
    /// </summary>
    [EnumMember(Value = "TJXT")]
    [IsoId("_vYTyqcMMEee-Vv_OVx0uAQ")]
    [Description(@"Rate change tax withholding related adjustment.")]
    RateChangeTaxWithholding,
    
    /// <summary>
    /// Reclassification tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXD".
    /// </summary>
    [EnumMember(Value = "TJXD")]
    [IsoId("_vYTyt8MMEee-Vv_OVx0uAQ")]
    [Description(@"Reclassification tax withholding related adjustment.")]
    ReclassificationTaxWithholding,
    
    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as "RRD1".
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_vYTyq8MMEee-Vv_OVx0uAQ")]
    [Description(@"Participant deposited a security within 10 days after a corporate action event has occurred.")]
    ReorganisationDepositPhaseOne,
    
    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as "RRD2".
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_vYTyqsMMEee-Vv_OVx0uAQ")]
    [Description(@"Participant deposited a security 10 days after a corporate action event has occurred.")]
    ReorganisationDepositPhaseTwo,
    
    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_vYdjgMMMEee-Vv_OVx0uAQ")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoSettlement,
    
    /// <summary>
    /// Reversal related adjustment.
    /// Encoded/decoded by serializers as "REVA".
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("_vYTyscMMEee-Vv_OVx0uAQ")]
    [Description(@"Reversal related adjustment.")]
    Reversal,
    
    /// <summary>
    /// Reversal of tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXR".
    /// </summary>
    [EnumMember(Value = "TJXR")]
    [IsoId("_vYdjiMMMEee-Vv_OVx0uAQ")]
    [Description(@"Reversal of tax withholding related adjustment.")]
    ReversalOfTaxWithholding,
    
    /// <summary>
    /// Rights protect related adjustment.
    /// Encoded/decoded by serializers as "RRRI".
    /// </summary>
    [EnumMember(Value = "RRRI")]
    [IsoId("_vYTyssMMEee-Vv_OVx0uAQ")]
    [Description(@"Rights protect related adjustment.")]
    RightsProtect,
    
    /// <summary>
    /// Rights sales related adjustment.
    /// Encoded/decoded by serializers as "RRRS".
    /// </summary>
    [EnumMember(Value = "RRRS")]
    [IsoId("_vYTyusMMEee-Vv_OVx0uAQ")]
    [Description(@"Rights sales related adjustment.")]
    RightsSales,
    
    /// <summary>
    /// Rights step up related adjustment.
    /// Encoded/decoded by serializers as "RRRU".
    /// </summary>
    [EnumMember(Value = "RRRU")]
    [IsoId("_vYdjhsMMEee-Vv_OVx0uAQ")]
    [Description(@"Rights step up related adjustment.")]
    RightsStepUp,
    
    /// <summary>
    /// Rights subscription related adjustment.
    /// Encoded/decoded by serializers as "RRRE".
    /// </summary>
    [EnumMember(Value = "RRRE")]
    [IsoId("_vYdjhcMMEee-Vv_OVx0uAQ")]
    [Description(@"Rights subscription related adjustment.")]
    RightsSubscription,
    
    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as "STOK".
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_vYdjh8MMEee-Vv_OVx0uAQ")]
    [Description(@"Stock loan transaction.")]
    StockLoanSettlement,
    
    /// <summary>
    /// Tax instruction change related adjustment.
    /// Encoded/decoded by serializers as "TJXI".
    /// </summary>
    [EnumMember(Value = "TJXI")]
    [IsoId("_vYTyrMMMEee-Vv_OVx0uAQ")]
    [Description(@"Tax instruction change related adjustment.")]
    TaxInstructionChange,
    
    /// <summary>
    /// Tender offer fraction related adjustment.
    /// Encoded/decoded by serializers as "RRT2".
    /// </summary>
    [EnumMember(Value = "RRT2")]
    [IsoId("_vYTytcMMEee-Vv_OVx0uAQ")]
    [Description(@"Tender offer fraction related adjustment.")]
    TenderOfferFraction,
    
    /// <summary>
    /// Warrant Participant delete related adjustment.
    /// Encoded/decoded by serializers as "RRWT".
    /// </summary>
    [EnumMember(Value = "RRWT")]
    [IsoId("_vYdjkMMMEee-Vv_OVx0uAQ")]
    [Description(@"Warrant Participant delete related adjustment.")]
    WarrantParticipantDelete,
    
    /// <summary>
    /// Warrant rate change related adjustment.
    /// Encoded/decoded by serializers as "RRWC".
    /// </summary>
    [EnumMember(Value = "RRWC")]
    [IsoId("_vYTyp8MMEee-Vv_OVx0uAQ")]
    [Description(@"Warrant rate change related adjustment.")]
    WarrantRateChange,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCAdjustmentPaymentTypeV3CodeMetadataExtensions
{
    private static readonly DTCAdjustmentPaymentTypeV3CodeDropdownSource _dropdownSource = new DTCAdjustmentPaymentTypeV3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCAdjustmentPaymentTypeV3CodeDropdownRow GetMetadata(this DTCAdjustmentPaymentTypeV3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


