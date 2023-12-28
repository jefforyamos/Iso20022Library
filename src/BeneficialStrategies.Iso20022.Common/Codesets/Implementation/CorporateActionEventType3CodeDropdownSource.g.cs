﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType3Code.  ISO2002 ID# _bFoOptp-Ed-ak6NoX_4Aeg_1101765603.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bFoOptp-Ed-ak6NoX_4Aeg_1101765603")]
public partial class CorporateActionEventType3CodeDropdownSource : EnumMetadataManager<CorporateActionEventType3Code,ICorporateActionEventType3CodeDropdownRow,CorporateActionEventType3CodeDropdownRow>
{
    public CorporateActionEventType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
