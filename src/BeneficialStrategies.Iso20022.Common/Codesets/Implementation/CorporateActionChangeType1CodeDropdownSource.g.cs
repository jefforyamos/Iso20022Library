﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionChangeType1Code.  ISO2002 ID# _bCy9ENp-Ed-ak6NoX_4Aeg_1029236450.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of changes.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionChangeType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bCy9ENp-Ed-ak6NoX_4Aeg_1029236450")]
public partial class CorporateActionChangeType1CodeDropdownSource : EnumMetadataManager<CorporateActionChangeType1Code,ICorporateActionChangeType1CodeDropdownRow,CorporateActionChangeType1CodeDropdownRow>
{
    public CorporateActionChangeType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionChangeType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
