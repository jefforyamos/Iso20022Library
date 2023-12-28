﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventStage3Code.  ISO2002 ID# _0WDegCUeEeOxdNEux54C3Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the stage of the CA event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventStage3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0WDegCUeEeOxdNEux54C3Q")]
public partial class CorporateActionEventStage3CodeDropdownSource : EnumMetadataManager<CorporateActionEventStage3Code,ICorporateActionEventStage3CodeDropdownRow,CorporateActionEventStage3CodeDropdownRow>
{
    public CorporateActionEventStage3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventStage3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
