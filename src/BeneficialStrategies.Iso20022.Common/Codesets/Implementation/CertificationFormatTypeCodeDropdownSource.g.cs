﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CertificationFormatTypeCode.  ISO2002 ID# _a78HI9p-Ed-ak6NoX_4Aeg_-1769527950.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the certification format required, that is, physical or electronic format.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICertificationFormatTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a78HI9p-Ed-ak6NoX_4Aeg_-1769527950")]
public partial class CertificationFormatTypeCodeDropdownSource : EnumMetadataManager<CertificationFormatTypeCode,ICertificationFormatTypeCodeDropdownRow,CertificationFormatTypeCodeDropdownRow>
{
    public CertificationFormatTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CertificationFormatTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
