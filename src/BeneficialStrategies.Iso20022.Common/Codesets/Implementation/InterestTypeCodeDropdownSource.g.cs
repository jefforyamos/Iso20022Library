﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterestTypeCode.  ISO2002 ID# __215c9ojEeC60axPepSq7g_-1926390567.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if the deal price is excluding or including the accrued interest.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterestTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__215c9ojEeC60axPepSq7g_-1926390567")]
public partial class InterestTypeCodeDropdownSource : EnumMetadataManager<InterestTypeCode,IInterestTypeCodeDropdownRow,InterestTypeCodeDropdownRow>
{
    public InterestTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterestTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
