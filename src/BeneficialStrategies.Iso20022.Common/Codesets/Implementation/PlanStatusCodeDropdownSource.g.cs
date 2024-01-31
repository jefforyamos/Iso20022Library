﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PlanStatusCode.  ISO2002 ID# _Bb8GsQjcEeS5F6qHcKOrew.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a plan.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPlanStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Bb8GsQjcEeS5F6qHcKOrew")]
public partial class PlanStatusCodeDropdownSource : EnumMetadataManager<PlanStatusCode,IPlanStatusCodeDropdownRow,PlanStatusCodeDropdownRow>
{
    public PlanStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PlanStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
