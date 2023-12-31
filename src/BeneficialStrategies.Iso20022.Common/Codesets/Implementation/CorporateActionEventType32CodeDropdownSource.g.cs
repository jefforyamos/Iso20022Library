﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType32Code.  ISO2002 ID# _ZLX6ceXlEemEj48jhmlA0Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType32CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZLX6ceXlEemEj48jhmlA0Q")]
public partial class CorporateActionEventType32CodeDropdownSource : EnumMetadataManager<CorporateActionEventType32Code,ICorporateActionEventType32CodeDropdownRow,CorporateActionEventType32CodeDropdownRow>
{
    public CorporateActionEventType32CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType32CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
