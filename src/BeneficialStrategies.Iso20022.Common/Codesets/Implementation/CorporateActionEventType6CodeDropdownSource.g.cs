﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType6Code.  ISO2002 ID# _bGX1g9p-Ed-ak6NoX_4Aeg_-653669298.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bGX1g9p-Ed-ak6NoX_4Aeg_-653669298")]
public partial class CorporateActionEventType6CodeDropdownSource : EnumMetadataManager<CorporateActionEventType6Code,ICorporateActionEventType6CodeDropdownRow,CorporateActionEventType6CodeDropdownRow>
{
    public CorporateActionEventType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
