﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SpecialPurpose2Code.  ISO2002 ID# _UdgZYMVcEeiYpLQka876sg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies blank or not available codes.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISpecialPurpose2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UdgZYMVcEeiYpLQka876sg")]
public partial class SpecialPurpose2CodeDropdownSource : EnumMetadataManager<SpecialPurpose2Code,ISpecialPurpose2CodeDropdownRow,SpecialPurpose2CodeDropdownRow>
{
    public SpecialPurpose2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SpecialPurpose2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
