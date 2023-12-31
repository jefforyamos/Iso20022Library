﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Frequency3Code.  ISO2002 ID# _Yajvh9p-Ed-ak6NoX_4Aeg_560112330.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrequency3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yajvh9p-Ed-ak6NoX_4Aeg_560112330")]
public partial class Frequency3CodeDropdownSource : EnumMetadataManager<Frequency3Code,IFrequency3CodeDropdownRow,Frequency3CodeDropdownRow>
{
    public Frequency3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Frequency3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
