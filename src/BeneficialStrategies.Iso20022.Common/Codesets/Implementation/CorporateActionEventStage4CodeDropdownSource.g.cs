﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventStage4Code.  ISO2002 ID# _nc7WUCUmEeO8eOSw0QN9mA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the stage of the CA lottery event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventStage4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nc7WUCUmEeO8eOSw0QN9mA")]
public partial class CorporateActionEventStage4CodeDropdownSource : EnumMetadataManager<CorporateActionEventStage4Code,ICorporateActionEventStage4CodeDropdownRow,CorporateActionEventStage4CodeDropdownRow>
{
    public CorporateActionEventStage4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventStage4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
