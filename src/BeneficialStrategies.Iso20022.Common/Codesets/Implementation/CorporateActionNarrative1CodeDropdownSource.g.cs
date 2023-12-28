﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionNarrative1Code.  ISO2002 ID# _bK2F0Np-Ed-ak6NoX_4Aeg_24208784.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the narrative type of a corporate action.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionNarrative1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bK2F0Np-Ed-ak6NoX_4Aeg_24208784")]
public partial class CorporateActionNarrative1CodeDropdownSource : EnumMetadataManager<CorporateActionNarrative1Code,ICorporateActionNarrative1CodeDropdownRow,CorporateActionNarrative1CodeDropdownRow>
{
    public CorporateActionNarrative1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionNarrative1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
