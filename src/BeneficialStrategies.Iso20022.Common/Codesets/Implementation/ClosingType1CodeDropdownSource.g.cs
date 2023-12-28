﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ClosingType1Code.  ISO2002 ID# _KgvwANonEeCWg-hsBVGrDA_-669343258.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the timing or method for terminating the agreement - for repos.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IClosingType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KgvwANonEeCWg-hsBVGrDA_-669343258")]
public partial class ClosingType1CodeDropdownSource : EnumMetadataManager<ClosingType1Code,IClosingType1CodeDropdownRow,ClosingType1CodeDropdownRow>
{
    public ClosingType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ClosingType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
