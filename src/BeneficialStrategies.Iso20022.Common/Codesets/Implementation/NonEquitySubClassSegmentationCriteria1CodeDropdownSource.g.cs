﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonEquitySubClassSegmentationCriteria1Code.  ISO2002 ID# _AyeSgIMNEeq-_7a8Z6CuPA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Criteria used to segment classes of non-equity instruments into sub classes as per local regulation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonEquitySubClassSegmentationCriteria1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AyeSgIMNEeq-_7a8Z6CuPA")]
public partial class NonEquitySubClassSegmentationCriteria1CodeDropdownSource : EnumMetadataManager<NonEquitySubClassSegmentationCriteria1Code,INonEquitySubClassSegmentationCriteria1CodeDropdownRow,NonEquitySubClassSegmentationCriteria1CodeDropdownRow>
{
    public NonEquitySubClassSegmentationCriteria1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonEquitySubClassSegmentationCriteria1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
