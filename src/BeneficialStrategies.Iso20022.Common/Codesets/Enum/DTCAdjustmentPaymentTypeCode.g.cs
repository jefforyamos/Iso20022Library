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
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_1596AzL3EeKU9IrkkToqcw_521941697")]
    [Description(@"Stock loan transaction.")]
    STOK,
    
    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_1596BDL3EeKU9IrkkToqcw_-1610908030")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    REPO,
    
    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_1596BTL3EeKU9IrkkToqcw_557568608")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FAIL,
    
    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_16HD8DL3EeKU9IrkkToqcw_2016520441")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MISC,
    
    /// <summary>
    /// Cash in lieu related adjustment.
    /// </summary>
    [EnumMember(Value = "RCIL")]
    [IsoId("_mIo-gGfCEeOB5r-GpjGdRQ")]
    [Description(@"Cash in lieu related adjustment.")]
    RCIL,
    
    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_rJ2OkGfCEeOB5r-GpjGdRQ")]
    [Description(@"Participant deposited a security within 10 days after a corporate action event has occurred.")]
    RRD1,
    
    /// <summary>
    /// Dynamic rate change related adjustment.
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_aadqsGfDEeOB5r-GpjGdRQ")]
    [Description(@"Dynamic rate change related adjustment.")]
    RRDR,
    
    /// <summary>
    /// Mandatory reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRMD")]
    [IsoId("_eHnR4GfDEeOB5r-GpjGdRQ")]
    [Description(@"Mandatory reorganization deposit related adjustment.")]
    RRMD,
    
    /// <summary>
    /// Mandatory legal reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRLR")]
    [IsoId("_eQikYGfDEeOB5r-GpjGdRQ")]
    [Description(@"Mandatory legal reorganization deposit related adjustment.")]
    RRLR,
    
    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_ebjhkGfDEeOB5r-GpjGdRQ")]
    [Description(@"Participant deposited a security 10 days after a corporate action event has occurred.")]
    RRD2,
    
    /// <summary>
    /// Claim settlement related adjustment.
    /// </summary>
    [EnumMember(Value = "RRCL")]
    [IsoId("_ehDsoGfDEeOB5r-GpjGdRQ")]
    [Description(@"Claim settlement related adjustment.")]
    RRCL,
    
    /// <summary>
    /// Custody reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_emaGsGfDEeOB5r-GpjGdRQ")]
    [Description(@"Custody reorganization deposit related adjustment.")]
    RRCD,
    
    /// <summary>
    /// Reversal related adjustment.
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("_erxH0GfDEeOB5r-GpjGdRQ")]
    [Description(@"Reversal related adjustment.")]
    REVA,
    
    /// <summary>
    /// Dividend payment on a DTC custody held security related adjustment.
    /// </summary>
    [EnumMember(Value = "RCDP")]
    [IsoId("_ew-X8GfDEeOB5r-GpjGdRQ")]
    [Description(@"Dividend payment on a DTC custody held security related adjustment.")]
    RCDP,
    
    /// <summary>
    /// ADR issue fee reversal adjustment.
    /// </summary>
    [EnumMember(Value = "RADR")]
    [IsoId("_e2LoEGfDEeOB5r-GpjGdRQ")]
    [Description(@"ADR issue fee reversal adjustment.")]
    RADR,
    
    /// <summary>
    /// American Depository R issue fee charge adjustment.
    /// </summary>
    [EnumMember(Value = "RADC")]
    [IsoId("_e7Y4MGfDEeOB5r-GpjGdRQ")]
    [Description(@"American Depository R issue fee charge adjustment.")]
    RADC,
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_fAmIUGfDEeOB5r-GpjGdRQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    OTHR,
    
    /// <summary>
    /// Warrant rate change related adjustment.
    /// </summary>
    [EnumMember(Value = "RRWC")]
    [IsoId("_P3h6oGfHEeOB5r-GpjGdRQ")]
    [Description(@"Warrant rate change related adjustment.")]
    RRWC,
    
    /// <summary>
    /// Tender offer fraction related adjustment.
    /// </summary>
    [EnumMember(Value = "RRT2")]
    [IsoId("_P-01cGfHEeOB5r-GpjGdRQ")]
    [Description(@"Tender offer fraction related adjustment.")]
    RRT2,
    
    /// <summary>
    /// Rights step up related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRU")]
    [IsoId("_QEeKcGfHEeOB5r-GpjGdRQ")]
    [Description(@"Rights step up related adjustment.")]
    RRRU,
    
    /// <summary>
    /// Rights sales related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRS")]
    [IsoId("_QKbBcGfHEeOB5r-GpjGdRQ")]
    [Description(@"Rights sales related adjustment.")]
    RRRS,
    
    /// <summary>
    /// Last day protect related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRL")]
    [IsoId("_QPyCkGfHEeOB5r-GpjGdRQ")]
    [Description(@"Last day protect related adjustment.")]
    RRRL,
    
    /// <summary>
    /// Rights protect related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRI")]
    [IsoId("_QVJDsGfHEeOB5r-GpjGdRQ")]
    [Description(@"Rights protect related adjustment.")]
    RRRI,
    
    /// <summary>
    /// Rights subscription related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRE")]
    [IsoId("_QafdwGfHEeOB5r-GpjGdRQ")]
    [Description(@"Rights subscription related adjustment.")]
    RRRE,
    
    /// <summary>
    /// Adjusted for rights subscription related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRA")]
    [IsoId("_Qf2e4GfHEeOB5r-GpjGdRQ")]
    [Description(@"Adjusted for rights subscription related adjustment.")]
    RRRA,
    
    /// <summary>
    /// Mandatory over three year reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRR3")]
    [IsoId("_QlNgAGfHEeOB5r-GpjGdRQ")]
    [Description(@"Mandatory over three year reorganization deposit related adjustment.")]
    RRR3,
    
    /// <summary>
    /// Legal reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRML")]
    [IsoId("_QqawIGfHEeOB5r-GpjGdRQ")]
    [Description(@"Legal reorganization deposit related adjustment.")]
    RRML,
    
    /// <summary>
    /// Manual user tax adjustment.
    /// </summary>
    [EnumMember(Value = "TJXU")]
    [IsoId("__XLRQGfHEeOB5r-GpjGdRQ")]
    [Description(@"Manual user tax adjustment.")]
    TJXU,
    
    /// <summary>
    /// Rate change tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXT")]
    [IsoId("_D3D88GfIEeOB5r-GpjGdRQ")]
    [Description(@"Rate change tax withholding related adjustment.")]
    TJXT,
    
    /// <summary>
    /// Reversal of tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXR")]
    [IsoId("_EG-oQGfIEeOB5r-GpjGdRQ")]
    [Description(@"Reversal of tax withholding related adjustment.")]
    TJXR,
    
    /// <summary>
    /// Original (initial) tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXO")]
    [IsoId("_EMxuQGfIEeOB5r-GpjGdRQ")]
    [Description(@"Original (initial) tax withholding related adjustment.")]
    TJXO,
    
    /// <summary>
    /// Original late tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXL")]
    [IsoId("_ESR5UGfIEeOB5r-GpjGdRQ")]
    [Description(@"Original late tax withholding related adjustment.")]
    TJXL,
    
    /// <summary>
    /// Tax instruction change related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXI")]
    [IsoId("_EXo6cGfIEeOB5r-GpjGdRQ")]
    [Description(@"Tax instruction change related adjustment.")]
    TJXI,
    
    /// <summary>
    /// Fail tracking tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXF")]
    [IsoId("_Ec_7kGfIEeOB5r-GpjGdRQ")]
    [Description(@"Fail tracking tax withholding related adjustment.")]
    TJXF,
    
    /// <summary>
    /// Reclassification tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXD")]
    [IsoId("_EiWVoGfIEeOB5r-GpjGdRQ")]
    [Description(@"Reclassification tax withholding related adjustment.")]
    TJXD,
    
    /// <summary>
    /// Warrant Participant delete related adjustment.
    /// </summary>
    [EnumMember(Value = "RRWT")]
    [IsoId("_EntWwGfIEeOB5r-GpjGdRQ")]
    [Description(@"Warrant Participant delete related adjustment.")]
    RRWT,
    
    /// <summary>
    /// Intra-day reversal of original tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXV")]
    [IsoId("_B96NgGfJEeOB5r-GpjGdRQ")]
    [Description(@"Intra-day reversal of original tax withholding related adjustment.")]
    TJXV,
    
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


