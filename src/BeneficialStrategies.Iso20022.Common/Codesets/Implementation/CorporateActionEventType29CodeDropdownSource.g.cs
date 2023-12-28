﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType29Code.  ISO2002 ID# _8HZN4eXkEemEj48jhmlA0Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType29CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8HZN4eXkEemEj48jhmlA0Q")]
public partial class CorporateActionEventType29CodeDropdownSource : EnumMetadataManager<CorporateActionEventType29Code,ICorporateActionEventType29CodeDropdownRow,CorporateActionEventType29CodeDropdownRow>
{
    public CorporateActionEventType29CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType29CodeDropdownRow(enumValue, memberInfo))
    {
    }
}