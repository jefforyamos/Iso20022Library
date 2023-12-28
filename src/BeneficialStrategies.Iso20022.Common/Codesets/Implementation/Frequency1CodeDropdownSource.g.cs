﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Frequency1Code.  ISO2002 ID# _ar_mp9p-Ed-ak6NoX_4Aeg_1946817553.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrequency1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ar_mp9p-Ed-ak6NoX_4Aeg_1946817553")]
public partial class Frequency1CodeDropdownSource : EnumMetadataManager<Frequency1Code,IFrequency1CodeDropdownRow,Frequency1CodeDropdownRow>
{
    public Frequency1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Frequency1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
