﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionOption3Code.  ISO2002 ID# _bLlst9p-Ed-ak6NoX_4Aeg_986310809.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of corporate action options.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionOption3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bLlst9p-Ed-ak6NoX_4Aeg_986310809")]
public partial class CorporateActionOption3CodeDropdownSource : EnumMetadataManager<CorporateActionOption3Code,ICorporateActionOption3CodeDropdownRow,CorporateActionOption3CodeDropdownRow>
{
    public CorporateActionOption3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionOption3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
