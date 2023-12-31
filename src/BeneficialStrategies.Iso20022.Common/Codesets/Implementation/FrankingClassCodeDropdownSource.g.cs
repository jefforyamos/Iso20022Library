﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FrankingClassCode.  ISO2002 ID# _WlzwAVfuEeOuDtoQo1qilA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code defining the dvidend / distribution class where this franking information applies to.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrankingClassCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WlzwAVfuEeOuDtoQo1qilA")]
public partial class FrankingClassCodeDropdownSource : EnumMetadataManager<FrankingClassCode,IFrankingClassCodeDropdownRow,FrankingClassCodeDropdownRow>
{
    public FrankingClassCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FrankingClassCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
