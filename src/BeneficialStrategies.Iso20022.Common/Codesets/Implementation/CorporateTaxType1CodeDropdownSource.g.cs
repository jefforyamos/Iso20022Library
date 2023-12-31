﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateTaxType1Code.  ISO2002 ID# _YZOAkC7REemIy6A-26wnAg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the corporate tax identification type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateTaxType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZOAkC7REemIy6A-26wnAg")]
public partial class CorporateTaxType1CodeDropdownSource : EnumMetadataManager<CorporateTaxType1Code,ICorporateTaxType1CodeDropdownRow,CorporateTaxType1CodeDropdownRow>
{
    public CorporateTaxType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateTaxType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
