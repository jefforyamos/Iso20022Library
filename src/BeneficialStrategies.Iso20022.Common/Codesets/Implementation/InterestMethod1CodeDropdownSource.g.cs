﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterestMethod1Code.  ISO2002 ID# _YbAbc9p-Ed-ak6NoX_4Aeg_1343964956.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the interest will be setlled in cash or rolled in.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterestMethod1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YbAbc9p-Ed-ak6NoX_4Aeg_1343964956")]
public partial class InterestMethod1CodeDropdownSource : EnumMetadataManager<InterestMethod1Code,IInterestMethod1CodeDropdownRow,InterestMethod1CodeDropdownRow>
{
    public InterestMethod1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterestMethod1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}