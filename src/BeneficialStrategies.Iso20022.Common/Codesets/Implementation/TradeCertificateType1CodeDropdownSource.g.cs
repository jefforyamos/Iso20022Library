﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeCertificateType1Code.  ISO2002 ID# _YmCmyNp-Ed-ak6NoX_4Aeg_-427114470.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of trade certificate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeCertificateType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YmCmyNp-Ed-ak6NoX_4Aeg_-427114470")]
public partial class TradeCertificateType1CodeDropdownSource : EnumMetadataManager<TradeCertificateType1Code,ITradeCertificateType1CodeDropdownRow,TradeCertificateType1CodeDropdownRow>
{
    public TradeCertificateType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeCertificateType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
