﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType15Code.  ISO2002 ID# _U_mfIGOAEeW4z96Yfj3Wng.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType15CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_U_mfIGOAEeW4z96Yfj3Wng")]
public partial class CorporateActionEventType15CodeDropdownSource : EnumMetadataManager<CorporateActionEventType15Code,ICorporateActionEventType15CodeDropdownRow,CorporateActionEventType15CodeDropdownRow>
{
    public CorporateActionEventType15CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType15CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
