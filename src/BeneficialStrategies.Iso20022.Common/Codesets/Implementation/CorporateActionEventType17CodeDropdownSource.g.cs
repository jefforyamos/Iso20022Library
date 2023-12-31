﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType17Code.  ISO2002 ID# _wlQsdGODEeW4z96Yfj3Wng.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType17CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wlQsdGODEeW4z96Yfj3Wng")]
public partial class CorporateActionEventType17CodeDropdownSource : EnumMetadataManager<CorporateActionEventType17Code,ICorporateActionEventType17CodeDropdownRow,CorporateActionEventType17CodeDropdownRow>
{
    public CorporateActionEventType17CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType17CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
