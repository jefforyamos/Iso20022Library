﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxWithholdingMethod2Code.  ISO2002 ID# _fjSuABKtEeKj15WxqwlXPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fjSuABKtEeKj15WxqwlXPw")]
[Description(@"Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.")]
[DerivedFrom(typeof(TaxWithholdingMethodCode))]
public enum TaxWithholdingMethod2Code
{
    /// <summary>
    /// Withholding tax is applied to a corporate.
    /// Encoded/decoded by serializers as "WHCO".
    /// </summary>
    [EnumMember(Value = "WHCO")]
    [IsoId("_hagHQRKtEeKj15WxqwlXPw")]
    [Description(@"Withholding tax is applied to a corporate.")]
    WithholdingCorporateTax = TaxWithholdingMethodCode.WithholdingCorporateTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax information is reported to the tax authorities and therefore not withheld at source.
    /// Encoded/decoded by serializers as "REPT".
    /// </summary>
    [EnumMember(Value = "REPT")]
    [IsoId("_hkCdwRKtEeKj15WxqwlXPw")]
    [Description(@"Tax information is reported to the tax authorities and therefore not withheld at source.")]
    ReportTax = TaxWithholdingMethodCode.ReportTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax certificate is provided by the beneficiary from its tax authority in its country of residence. Therefore, the obligation of withholding tax is waived and tax information will be reported to the tax authorities.
    /// Encoded/decoded by serializers as "CRTF".
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_hsYhcRKtEeKj15WxqwlXPw")]
    [Description(@"Tax certificate is provided by the beneficiary from its tax authority in its country of residence. Therefore, the obligation of withholding tax is waived and tax information will be reported to the tax authorities.")]
    TaxCertificate = TaxWithholdingMethodCode.TaxCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is withheld at source.
    /// Encoded/decoded by serializers as "WTHD".
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_h1CHIRKtEeKj15WxqwlXPw")]
    [Description(@"Tax is withheld at source.")]
    WithholdTax = TaxWithholdingMethodCode.WithholdTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is withheld at source and the tax information is also reported to the tax authorities.
    /// Encoded/decoded by serializers as "WTRE".
    /// </summary>
    [EnumMember(Value = "WTRE")]
    [IsoId("_h-kdoRKtEeKj15WxqwlXPw")]
    [Description(@"Tax is withheld at source and the tax information is also reported to the tax authorities.")]
    WithholdTaxAndReport = TaxWithholdingMethodCode.WithholdTaxAndReport, // same ordinal as derivation source for type conversions
    
}
