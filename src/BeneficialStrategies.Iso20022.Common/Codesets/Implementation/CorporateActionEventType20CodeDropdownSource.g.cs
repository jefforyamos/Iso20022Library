﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType20Code.  ISO2002 ID# _TdWZgIr6EeaNFeVGetd6Xw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType20CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TdWZgIr6EeaNFeVGetd6Xw")]
public partial class CorporateActionEventType20CodeDropdownSource : EnumMetadataManager<CorporateActionEventType20Code,ICorporateActionEventType20CodeDropdownRow,CorporateActionEventType20CodeDropdownRow>
{
    public CorporateActionEventType20CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType20CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
