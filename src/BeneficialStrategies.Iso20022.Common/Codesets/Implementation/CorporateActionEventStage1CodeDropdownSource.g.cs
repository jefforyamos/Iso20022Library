﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventStage1Code.  ISO2002 ID# _bDsU8Np-Ed-ak6NoX_4Aeg_1114905444.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the stage of the CA event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventStage1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bDsU8Np-Ed-ak6NoX_4Aeg_1114905444")]
public partial class CorporateActionEventStage1CodeDropdownSource : EnumMetadataManager<CorporateActionEventStage1Code,ICorporateActionEventStage1CodeDropdownRow,CorporateActionEventStage1CodeDropdownRow>
{
    public CorporateActionEventStage1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventStage1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}