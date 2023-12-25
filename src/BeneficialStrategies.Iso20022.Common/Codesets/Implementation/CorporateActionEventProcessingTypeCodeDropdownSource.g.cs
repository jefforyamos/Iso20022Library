﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventProcessingTypeCode.  ISO2002 ID# _bDij9dp-Ed-ak6NoX_4Aeg_-1352374921.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of event processing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventProcessingTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bDij9dp-Ed-ak6NoX_4Aeg_-1352374921")]
public partial class CorporateActionEventProcessingTypeCodeDropdownSource : EnumMetadataManager<CorporateActionEventProcessingTypeCode,ICorporateActionEventProcessingTypeCodeDropdownRow,CorporateActionEventProcessingTypeCodeDropdownRow>
{
    public CorporateActionEventProcessingTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventProcessingTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
