﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCAdjustmentPaymentTypeCode.  ISO2002 ID# _1596AjL3EeKU9IrkkToqcw_604755417.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1596AjL3EeKU9IrkkToqcw_604755417")]
[Description(@"Specifies the type of the payment adjustment.")]
public enum DTCAdjustmentPaymentTypeCode
{
    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as "STOK".
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_1596AzL3EeKU9IrkkToqcw_521941697")]
    [Description(@"Stock loan transaction.")]
    StockLoanPayment,
    
    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_1596BDL3EeKU9IrkkToqcw_-1610908030")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoPayment,
    
    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_1596BTL3EeKU9IrkkToqcw_557568608")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailPayment,
    
    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as "MISC".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_16HD8DL3EeKU9IrkkToqcw_2016520441")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousPayment,
    
    /// <summary>
    /// Cash in lieu related adjustment.
    /// Encoded/decoded by serializers as "RCIL".
    /// </summary>
    [EnumMember(Value = "RCIL")]
    [IsoId("_mIo-gGfCEeOB5r-GpjGdRQ")]
    [Description(@"Cash in lieu related adjustment.")]
    CashInLieu,
    
    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as "RRD1".
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_rJ2OkGfCEeOB5r-GpjGdRQ")]
    [Description(@"Participant deposited a security within 10 days after a corporate action event has occurred.")]
    ReorganisationDepositPhaseOne,
    
    /// <summary>
    /// Dynamic rate change related adjustment.
    /// Encoded/decoded by serializers as "RRDR".
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_aadqsGfDEeOB5r-GpjGdRQ")]
    [Description(@"Dynamic rate change related adjustment.")]
    DynamicRateChange,
    
    /// <summary>
    /// Mandatory reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as "RRMD".
    /// </summary>
    [EnumMember(Value = "RRMD")]
    [IsoId("_eHnR4GfDEeOB5r-GpjGdRQ")]
    [Description(@"Mandatory reorganization deposit related adjustment.")]
    MandatoryReorganizationDeposit,
    
    /// <summary>
    /// Mandatory legal reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as "RRLR".
    /// </summary>
    [EnumMember(Value = "RRLR")]
    [IsoId("_eQikYGfDEeOB5r-GpjGdRQ")]
    [Description(@"Mandatory legal reorganization deposit related adjustment.")]
    MandatoryLegalReorgDeposit,
    
    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as "RRD2".
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_ebjhkGfDEeOB5r-GpjGdRQ")]
    [Description(@"Participant deposited a security 10 days after a corporate action event has occurred.")]
    ReorgDepositPhaseTwo,
    
    /// <summary>
    /// Claim settlement related adjustment.
    /// Encoded/decoded by serializers as "RRCL".
    /// </summary>
    [EnumMember(Value = "RRCL")]
    [IsoId("_ehDsoGfDEeOB5r-GpjGdRQ")]
    [Description(@"Claim settlement related adjustment.")]
    ClaimSettlement,
    
    /// <summary>
    /// Custody reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as "RRCD".
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_emaGsGfDEeOB5r-GpjGdRQ")]
    [Description(@"Custody reorganization deposit related adjustment.")]
    CustodyReorganizationDeposit,
    
    /// <summary>
    /// Reversal related adjustment.
    /// Encoded/decoded by serializers as "REVA".
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("_erxH0GfDEeOB5r-GpjGdRQ")]
    [Description(@"Reversal related adjustment.")]
    Reversal,
    
    /// <summary>
    /// Dividend payment on a DTC custody held security related adjustment.
    /// Encoded/decoded by serializers as "RCDP".
    /// </summary>
    [EnumMember(Value = "RCDP")]
    [IsoId("_ew-X8GfDEeOB5r-GpjGdRQ")]
    [Description(@"Dividend payment on a DTC custody held security related adjustment.")]
    CustodyDividendPayment,
    
    /// <summary>
    /// ADR issue fee reversal adjustment.
    /// Encoded/decoded by serializers as "RADR".
    /// </summary>
    [EnumMember(Value = "RADR")]
    [IsoId("_e2LoEGfDEeOB5r-GpjGdRQ")]
    [Description(@"ADR issue fee reversal adjustment.")]
    ADRIssueFeeReversal,
    
    /// <summary>
    /// American Depository R issue fee charge adjustment.
    /// Encoded/decoded by serializers as "RADC".
    /// </summary>
    [EnumMember(Value = "RADC")]
    [IsoId("_e7Y4MGfDEeOB5r-GpjGdRQ")]
    [Description(@"American Depository R issue fee charge adjustment.")]
    ADRIssueFeeCharge,
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_fAmIUGfDEeOB5r-GpjGdRQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,
    
    /// <summary>
    /// Warrant rate change related adjustment.
    /// Encoded/decoded by serializers as "RRWC".
    /// </summary>
    [EnumMember(Value = "RRWC")]
    [IsoId("_P3h6oGfHEeOB5r-GpjGdRQ")]
    [Description(@"Warrant rate change related adjustment.")]
    WarrantRateChange,
    
    /// <summary>
    /// Tender offer fraction related adjustment.
    /// Encoded/decoded by serializers as "RRT2".
    /// </summary>
    [EnumMember(Value = "RRT2")]
    [IsoId("_P-01cGfHEeOB5r-GpjGdRQ")]
    [Description(@"Tender offer fraction related adjustment.")]
    TenderOfferFraction,
    
    /// <summary>
    /// Rights step up related adjustment.
    /// Encoded/decoded by serializers as "RRRU".
    /// </summary>
    [EnumMember(Value = "RRRU")]
    [IsoId("_QEeKcGfHEeOB5r-GpjGdRQ")]
    [Description(@"Rights step up related adjustment.")]
    RightsStepUp,
    
    /// <summary>
    /// Rights sales related adjustment.
    /// Encoded/decoded by serializers as "RRRS".
    /// </summary>
    [EnumMember(Value = "RRRS")]
    [IsoId("_QKbBcGfHEeOB5r-GpjGdRQ")]
    [Description(@"Rights sales related adjustment.")]
    RightsSales,
    
    /// <summary>
    /// Last day protect related adjustment.
    /// Encoded/decoded by serializers as "RRRL".
    /// </summary>
    [EnumMember(Value = "RRRL")]
    [IsoId("_QPyCkGfHEeOB5r-GpjGdRQ")]
    [Description(@"Last day protect related adjustment.")]
    LastDayProtect,
    
    /// <summary>
    /// Rights protect related adjustment.
    /// Encoded/decoded by serializers as "RRRI".
    /// </summary>
    [EnumMember(Value = "RRRI")]
    [IsoId("_QVJDsGfHEeOB5r-GpjGdRQ")]
    [Description(@"Rights protect related adjustment.")]
    RightsProtect,
    
    /// <summary>
    /// Rights subscription related adjustment.
    /// Encoded/decoded by serializers as "RRRE".
    /// </summary>
    [EnumMember(Value = "RRRE")]
    [IsoId("_QafdwGfHEeOB5r-GpjGdRQ")]
    [Description(@"Rights subscription related adjustment.")]
    RightsSubscription,
    
    /// <summary>
    /// Adjusted for rights subscription related adjustment.
    /// Encoded/decoded by serializers as "RRRA".
    /// </summary>
    [EnumMember(Value = "RRRA")]
    [IsoId("_Qf2e4GfHEeOB5r-GpjGdRQ")]
    [Description(@"Adjusted for rights subscription related adjustment.")]
    AdjustedForRightsSubscription,
    
    /// <summary>
    /// Mandatory over three year reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as "RRR3".
    /// </summary>
    [EnumMember(Value = "RRR3")]
    [IsoId("_QlNgAGfHEeOB5r-GpjGdRQ")]
    [Description(@"Mandatory over three year reorganization deposit related adjustment.")]
    MandatoryOverThreeYearReorganizationDeposit,
    
    /// <summary>
    /// Legal reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as "RRML".
    /// </summary>
    [EnumMember(Value = "RRML")]
    [IsoId("_QqawIGfHEeOB5r-GpjGdRQ")]
    [Description(@"Legal reorganization deposit related adjustment.")]
    LegalReorganizationDeposits,
    
    /// <summary>
    /// Manual user tax adjustment.
    /// Encoded/decoded by serializers as "TJXU".
    /// </summary>
    [EnumMember(Value = "TJXU")]
    [IsoId("__XLRQGfHEeOB5r-GpjGdRQ")]
    [Description(@"Manual user tax adjustment.")]
    ManualUserTax,
    
    /// <summary>
    /// Rate change tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXT".
    /// </summary>
    [EnumMember(Value = "TJXT")]
    [IsoId("_D3D88GfIEeOB5r-GpjGdRQ")]
    [Description(@"Rate change tax withholding related adjustment.")]
    RateChangeTaxWithholding,
    
    /// <summary>
    /// Reversal of tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXR".
    /// </summary>
    [EnumMember(Value = "TJXR")]
    [IsoId("_EG-oQGfIEeOB5r-GpjGdRQ")]
    [Description(@"Reversal of tax withholding related adjustment.")]
    ReversalOfTaxWithholding,
    
    /// <summary>
    /// Original (initial) tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXO".
    /// </summary>
    [EnumMember(Value = "TJXO")]
    [IsoId("_EMxuQGfIEeOB5r-GpjGdRQ")]
    [Description(@"Original (initial) tax withholding related adjustment.")]
    OriginalInitialTaxWithholding,
    
    /// <summary>
    /// Original late tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXL".
    /// </summary>
    [EnumMember(Value = "TJXL")]
    [IsoId("_ESR5UGfIEeOB5r-GpjGdRQ")]
    [Description(@"Original late tax withholding related adjustment.")]
    OriginalLateTaxWithholding,
    
    /// <summary>
    /// Tax instruction change related adjustment.
    /// Encoded/decoded by serializers as "TJXI".
    /// </summary>
    [EnumMember(Value = "TJXI")]
    [IsoId("_EXo6cGfIEeOB5r-GpjGdRQ")]
    [Description(@"Tax instruction change related adjustment.")]
    TaxInstructionChange,
    
    /// <summary>
    /// Fail tracking tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXF".
    /// </summary>
    [EnumMember(Value = "TJXF")]
    [IsoId("_Ec_7kGfIEeOB5r-GpjGdRQ")]
    [Description(@"Fail tracking tax withholding related adjustment.")]
    FailTrackingTaxWithholding,
    
    /// <summary>
    /// Reclassification tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXD".
    /// </summary>
    [EnumMember(Value = "TJXD")]
    [IsoId("_EiWVoGfIEeOB5r-GpjGdRQ")]
    [Description(@"Reclassification tax withholding related adjustment.")]
    ReclassificationTaxWithholding,
    
    /// <summary>
    /// Warrant Participant delete related adjustment.
    /// Encoded/decoded by serializers as "RRWT".
    /// </summary>
    [EnumMember(Value = "RRWT")]
    [IsoId("_EntWwGfIEeOB5r-GpjGdRQ")]
    [Description(@"Warrant Participant delete related adjustment.")]
    WarrantParticipantDelete,
    
    /// <summary>
    /// Intra-day reversal of original tax withholding related adjustment.
    /// Encoded/decoded by serializers as "TJXV".
    /// </summary>
    [EnumMember(Value = "TJXV")]
    [IsoId("_B96NgGfJEeOB5r-GpjGdRQ")]
    [Description(@"Intra-day reversal of original tax withholding related adjustment.")]
    IntraDayReversalOfOriginalTaxWithholding,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCAdjustmentPaymentTypeCodeMetadataExtensions
{
    private static readonly DTCAdjustmentPaymentTypeCodeDropdownSource _dropdownSource = new DTCAdjustmentPaymentTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCAdjustmentPaymentTypeCodeDropdownRow GetMetadata(this DTCAdjustmentPaymentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

