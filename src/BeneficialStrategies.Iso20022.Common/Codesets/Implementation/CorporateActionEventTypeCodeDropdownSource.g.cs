﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventTypeCode.  ISO2002 ID# _bHRNZtp-Ed-ak6NoX_4Aeg_-1565392153.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bHRNZtp-Ed-ak6NoX_4Aeg_-1565392153")]
public partial class CorporateActionEventTypeCodeDropdownSource : EnumMetadataManager<CorporateActionEventTypeCode,ICorporateActionEventTypeCodeDropdownRow,CorporateActionEventTypeCodeDropdownRow>
{
    public CorporateActionEventTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
