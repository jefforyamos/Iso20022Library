﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeCertificateTypeCode.  ISO2002 ID# _YmVhstp-Ed-ak6NoX_4Aeg_706311619.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of trade certificate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeCertificateTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YmVhstp-Ed-ak6NoX_4Aeg_706311619")]
public partial class TradeCertificateTypeCodeDropdownSource : EnumMetadataManager<TradeCertificateTypeCode,ITradeCertificateTypeCodeDropdownRow,TradeCertificateTypeCodeDropdownRow>
{
    public TradeCertificateTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeCertificateTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
