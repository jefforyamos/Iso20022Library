﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeCertificateType2Code.  ISO2002 ID# _YmLwt9p-Ed-ak6NoX_4Aeg_1999753422.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of trade certificate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeCertificateType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YmLwt9p-Ed-ak6NoX_4Aeg_1999753422")]
public partial class TradeCertificateType2CodeDropdownSource : EnumMetadataManager<TradeCertificateType2Code,ITradeCertificateType2CodeDropdownRow,TradeCertificateType2CodeDropdownRow>
{
    public TradeCertificateType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeCertificateType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
