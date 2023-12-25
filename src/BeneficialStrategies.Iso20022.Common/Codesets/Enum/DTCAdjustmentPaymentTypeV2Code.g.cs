﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCAdjustmentPaymentTypeV2Code.  ISO2002 ID# _cmC3IHxsEeOCOoRiuJeDeg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cmC3IHxsEeOCOoRiuJeDeg")]
[Description(@"Specifies the type of the payment adjustment.")]
public enum DTCAdjustmentPaymentTypeV2Code
{
    /// <summary>
    /// Adjusted for rights subscription related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRA")]
    [IsoId("_kPhxGnxsEeOCOoRiuJeDeg")]
    [Description(@"Adjusted for rights subscription related adjustment.")]
    RRRA,
    
    /// <summary>
    /// American Depository R issue fee charge adjustment.
    /// </summary>
    [EnumMember(Value = "RADC")]
    [IsoId("_kPhxG3xsEeOCOoRiuJeDeg")]
    [Description(@"American Depository R issue fee charge adjustment.")]
    RADC,
    
    /// <summary>
    /// ADR issue fee reversal adjustment.
    /// </summary>
    [EnumMember(Value = "RADR")]
    [IsoId("_kPhxHHxsEeOCOoRiuJeDeg")]
    [Description(@"ADR issue fee reversal adjustment.")]
    RADR,
    
    /// <summary>
    /// Cash in lieu related adjustment.
    /// </summary>
    [EnumMember(Value = "RCIL")]
    [IsoId("_kPhxHXxsEeOCOoRiuJeDeg")]
    [Description(@"Cash in lieu related adjustment.")]
    RCIL,
    
    /// <summary>
    /// Claim settlement related adjustment.
    /// </summary>
    [EnumMember(Value = "RRCL")]
    [IsoId("_kPhxHnxsEeOCOoRiuJeDeg")]
    [Description(@"Claim settlement related adjustment.")]
    RRCL,
    
    /// <summary>
    /// Dividend payment on a DTC custody held security related adjustment.
    /// </summary>
    [EnumMember(Value = "RCDP")]
    [IsoId("_kPhxH3xsEeOCOoRiuJeDeg")]
    [Description(@"Dividend payment on a DTC custody held security related adjustment.")]
    RCDP,
    
    /// <summary>
    /// Custody reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_kPhxIHxsEeOCOoRiuJeDeg")]
    [Description(@"Custody reorganization deposit related adjustment.")]
    RRCD,
    
    /// <summary>
    /// Dynamic rate change related adjustment.
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_kPhxIXxsEeOCOoRiuJeDeg")]
    [Description(@"Dynamic rate change related adjustment.")]
    RRDR,
    
    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_kPhxInxsEeOCOoRiuJeDeg")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FAIL,
    
    /// <summary>
    /// Fail tracking tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXF")]
    [IsoId("_kPhxI3xsEeOCOoRiuJeDeg")]
    [Description(@"Fail tracking tax withholding related adjustment.")]
    TJXF,
    
    /// <summary>
    /// Intra-day reversal of original tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXV")]
    [IsoId("_kPhxJHxsEeOCOoRiuJeDeg")]
    [Description(@"Intra-day reversal of original tax withholding related adjustment.")]
    TJXV,
    
    /// <summary>
    /// Last day protect related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRL")]
    [IsoId("_kPhxJXxsEeOCOoRiuJeDeg")]
    [Description(@"Last day protect related adjustment.")]
    RRRL,
    
    /// <summary>
    /// Legal reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRML")]
    [IsoId("_kPhxJnxsEeOCOoRiuJeDeg")]
    [Description(@"Legal reorganization deposit related adjustment.")]
    RRML,
    
    /// <summary>
    /// Mandatory legal reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRLR")]
    [IsoId("_kPhxJ3xsEeOCOoRiuJeDeg")]
    [Description(@"Mandatory legal reorganization deposit related adjustment.")]
    RRLR,
    
    /// <summary>
    /// Mandatory over three year reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRR3")]
    [IsoId("_kPhxKHxsEeOCOoRiuJeDeg")]
    [Description(@"Mandatory over three year reorganization deposit related adjustment.")]
    RRR3,
    
    /// <summary>
    /// Mandatory reorganization deposit related adjustment.
    /// </summary>
    [EnumMember(Value = "RRMD")]
    [IsoId("_kPhxKXxsEeOCOoRiuJeDeg")]
    [Description(@"Mandatory reorganization deposit related adjustment.")]
    RRMD,
    
    /// <summary>
    /// Manual user tax adjustment.
    /// </summary>
    [EnumMember(Value = "TJXU")]
    [IsoId("_kPhxKnxsEeOCOoRiuJeDeg")]
    [Description(@"Manual user tax adjustment.")]
    TJXU,
    
    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_kPhxK3xsEeOCOoRiuJeDeg")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MISC,
    
    /// <summary>
    /// Original (initial) tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXO")]
    [IsoId("_kPhxLHxsEeOCOoRiuJeDeg")]
    [Description(@"Original (initial) tax withholding related adjustment.")]
    TJXO,
    
    /// <summary>
    /// Original late tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXL")]
    [IsoId("_kPhxLXxsEeOCOoRiuJeDeg")]
    [Description(@"Original late tax withholding related adjustment.")]
    TJXL,
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_kPhxLnxsEeOCOoRiuJeDeg")]
    [Description(@"Reserved for new user defined reason codes.")]
    OTHR,
    
    /// <summary>
    /// Rate change tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXT")]
    [IsoId("_kPhxL3xsEeOCOoRiuJeDeg")]
    [Description(@"Rate change tax withholding related adjustment.")]
    TJXT,
    
    /// <summary>
    /// Reclassification tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXD")]
    [IsoId("_kPhxMHxsEeOCOoRiuJeDeg")]
    [Description(@"Reclassification tax withholding related adjustment.")]
    TJXD,
    
    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_kPhxMXxsEeOCOoRiuJeDeg")]
    [Description(@"Participant deposited a security within 10 days after a corporate action event has occurred.")]
    RRD1,
    
    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_kPhxMnxsEeOCOoRiuJeDeg")]
    [Description(@"Participant deposited a security 10 days after a corporate action event has occurred.")]
    RRD2,
    
    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_kPhxM3xsEeOCOoRiuJeDeg")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    REPO,
    
    /// <summary>
    /// Reversal related adjustment.
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("_kPhxNHxsEeOCOoRiuJeDeg")]
    [Description(@"Reversal related adjustment.")]
    REVA,
    
    /// <summary>
    /// Reversal of tax withholding related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXR")]
    [IsoId("_kPhxNXxsEeOCOoRiuJeDeg")]
    [Description(@"Reversal of tax withholding related adjustment.")]
    TJXR,
    
    /// <summary>
    /// Rights protect related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRI")]
    [IsoId("_kPhxNnxsEeOCOoRiuJeDeg")]
    [Description(@"Rights protect related adjustment.")]
    RRRI,
    
    /// <summary>
    /// Rights sales related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRS")]
    [IsoId("_kPhxN3xsEeOCOoRiuJeDeg")]
    [Description(@"Rights sales related adjustment.")]
    RRRS,
    
    /// <summary>
    /// Rights step up related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRU")]
    [IsoId("_kPhxOHxsEeOCOoRiuJeDeg")]
    [Description(@"Rights step up related adjustment.")]
    RRRU,
    
    /// <summary>
    /// Rights subscription related adjustment.
    /// </summary>
    [EnumMember(Value = "RRRE")]
    [IsoId("_kPhxOXxsEeOCOoRiuJeDeg")]
    [Description(@"Rights subscription related adjustment.")]
    RRRE,
    
    /// <summary>
    /// Stock loan transaction.
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_kPhxOnxsEeOCOoRiuJeDeg")]
    [Description(@"Stock loan transaction.")]
    STOK,
    
    /// <summary>
    /// Tax instruction change related adjustment.
    /// </summary>
    [EnumMember(Value = "TJXI")]
    [IsoId("_kPhxO3xsEeOCOoRiuJeDeg")]
    [Description(@"Tax instruction change related adjustment.")]
    TJXI,
    
    /// <summary>
    /// Tender offer fraction related adjustment.
    /// </summary>
    [EnumMember(Value = "RRT2")]
    [IsoId("_kPhxPHxsEeOCOoRiuJeDeg")]
    [Description(@"Tender offer fraction related adjustment.")]
    RRT2,
    
    /// <summary>
    /// Warrant Participant delete related adjustment.
    /// </summary>
    [EnumMember(Value = "RRWT")]
    [IsoId("_kPhxPXxsEeOCOoRiuJeDeg")]
    [Description(@"Warrant Participant delete related adjustment.")]
    RRWT,
    
    /// <summary>
    /// Warrant rate change related adjustment.
    /// </summary>
    [EnumMember(Value = "RRWC")]
    [IsoId("_kPhxPnxsEeOCOoRiuJeDeg")]
    [Description(@"Warrant rate change related adjustment.")]
    RRWC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCAdjustmentPaymentTypeV2CodeMetadataExtensions
{
    private static readonly DTCAdjustmentPaymentTypeV2CodeDropdownSource _dropdownSource = new DTCAdjustmentPaymentTypeV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCAdjustmentPaymentTypeV2CodeDropdownRow GetMetadata(this DTCAdjustmentPaymentTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


