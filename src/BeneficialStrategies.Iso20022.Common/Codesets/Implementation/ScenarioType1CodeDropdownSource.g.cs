﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ScenarioType1Code.  ISO2002 ID# _UgCXYKssEeayv9XxdmMwKQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Classification of the methodology used to derive a stress testing scenario.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IScenarioType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UgCXYKssEeayv9XxdmMwKQ")]
public partial class ScenarioType1CodeDropdownSource : EnumMetadataManager<ScenarioType1Code,IScenarioType1CodeDropdownRow,ScenarioType1CodeDropdownRow>
{
    public ScenarioType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ScenarioType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}