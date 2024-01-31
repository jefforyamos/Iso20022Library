﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionOptionTypeCode.  ISO2002 ID# _bRQP1Np-Ed-ak6NoX_4Aeg_1657166115.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of CA options.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionOptionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bRQP1Np-Ed-ak6NoX_4Aeg_1657166115")]
public partial class CorporateActionOptionTypeCodeDropdownSource : EnumMetadataManager<CorporateActionOptionTypeCode,ICorporateActionOptionTypeCodeDropdownRow,CorporateActionOptionTypeCodeDropdownRow>
{
    public CorporateActionOptionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionOptionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
