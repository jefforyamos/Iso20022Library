﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PrioritisationCode.  ISO2002 ID# _aKBiBNp-Ed-ak6NoX_4Aeg_-62106922.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if one side or the other of a cross order should be prioritized.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPrioritisationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKBiBNp-Ed-ak6NoX_4Aeg_-62106922")]
public partial class PrioritisationCodeDropdownSource : EnumMetadataManager<PrioritisationCode,IPrioritisationCodeDropdownRow,PrioritisationCodeDropdownRow>
{
    public PrioritisationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PrioritisationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
