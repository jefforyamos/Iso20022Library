﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType19Code.  ISO2002 ID# _yyVylGOEEeW4z96Yfj3Wng.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType19CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yyVylGOEEeW4z96Yfj3Wng")]
public partial class CorporateActionEventType19CodeDropdownSource : EnumMetadataManager<CorporateActionEventType19Code,ICorporateActionEventType19CodeDropdownRow,CorporateActionEventType19CodeDropdownRow>
{
    public CorporateActionEventType19CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType19CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
