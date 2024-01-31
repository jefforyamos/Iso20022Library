﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LumpSumType1Code.  ISO2002 ID# _TQu1cLKeEeiXL6Ccd-oU8g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of lump sum.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILumpSumType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TQu1cLKeEeiXL6Ccd-oU8g")]
public partial class LumpSumType1CodeDropdownSource : EnumMetadataManager<LumpSumType1Code,ILumpSumType1CodeDropdownRow,LumpSumType1CodeDropdownRow>
{
    public LumpSumType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new LumpSumType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
