﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventTypeV5Code.  ISO2002 ID# _MxhgL2N_EeW4z96Yfj3Wng.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventTypeV5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MxhgL2N_EeW4z96Yfj3Wng")]
public partial class CorporateActionEventTypeV5CodeDropdownSource : EnumMetadataManager<CorporateActionEventTypeV5Code,ICorporateActionEventTypeV5CodeDropdownRow,CorporateActionEventTypeV5CodeDropdownRow>
{
    public CorporateActionEventTypeV5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventTypeV5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
