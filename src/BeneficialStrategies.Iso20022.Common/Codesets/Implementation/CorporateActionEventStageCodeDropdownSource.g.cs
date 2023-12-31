﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventStageCode.  ISO2002 ID# _bD_P4Np-Ed-ak6NoX_4Aeg_-1886893264.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the stage of the CA event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventStageCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bD_P4Np-Ed-ak6NoX_4Aeg_-1886893264")]
public partial class CorporateActionEventStageCodeDropdownSource : EnumMetadataManager<CorporateActionEventStageCode,ICorporateActionEventStageCodeDropdownRow,CorporateActionEventStageCodeDropdownRow>
{
    public CorporateActionEventStageCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventStageCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
