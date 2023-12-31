﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MatchingProcessCode.  ISO2002 ID# _aVDGQNp-Ed-ak6NoX_4Aeg_-850156011.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the action to be performed on the matching process.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMatchingProcessCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aVDGQNp-Ed-ak6NoX_4Aeg_-850156011")]
public partial class MatchingProcessCodeDropdownSource : EnumMetadataManager<MatchingProcessCode,IMatchingProcessCodeDropdownRow,MatchingProcessCodeDropdownRow>
{
    public MatchingProcessCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MatchingProcessCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
