﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ScenarioTypeCode.  ISO2002 ID# _Bd4VEKssEeayv9XxdmMwKQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of scenario based on how the risk factors moves for that scenario were conceived.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IScenarioTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Bd4VEKssEeayv9XxdmMwKQ")]
public partial class ScenarioTypeCodeDropdownSource : EnumMetadataManager<ScenarioTypeCode,IScenarioTypeCodeDropdownRow,ScenarioTypeCodeDropdownRow>
{
    public ScenarioTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ScenarioTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
