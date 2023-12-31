﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Frequency2Code.  ISO2002 ID# _asJXqNp-Ed-ak6NoX_4Aeg_1505345791.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrequency2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_asJXqNp-Ed-ak6NoX_4Aeg_1505345791")]
public partial class Frequency2CodeDropdownSource : EnumMetadataManager<Frequency2Code,IFrequency2CodeDropdownRow,Frequency2CodeDropdownRow>
{
    public Frequency2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Frequency2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
