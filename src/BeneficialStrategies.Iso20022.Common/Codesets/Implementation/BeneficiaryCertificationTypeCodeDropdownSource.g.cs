﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BeneficiaryCertificationTypeCode.  ISO2002 ID# _beD8xtp-Ed-ak6NoX_4Aeg_-2069893638.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBeneficiaryCertificationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_beD8xtp-Ed-ak6NoX_4Aeg_-2069893638")]
public partial class BeneficiaryCertificationTypeCodeDropdownSource : EnumMetadataManager<BeneficiaryCertificationTypeCode,IBeneficiaryCertificationTypeCodeDropdownRow,BeneficiaryCertificationTypeCodeDropdownRow>
{
    public BeneficiaryCertificationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new BeneficiaryCertificationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
