﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionStyle6Code.  ISO2002 ID# _PCi1EM2GEeS6sY79p-9Zxw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how an option can be exercised.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionStyle6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_PCi1EM2GEeS6sY79p-9Zxw")]
public partial class OptionStyle6CodeDropdownSource : EnumMetadataManager<OptionStyle6Code,IOptionStyle6CodeDropdownRow,OptionStyle6CodeDropdownRow>
{
    public OptionStyle6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionStyle6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
