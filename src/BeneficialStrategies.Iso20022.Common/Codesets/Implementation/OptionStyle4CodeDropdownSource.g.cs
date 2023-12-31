﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionStyle4Code.  ISO2002 ID# __viXkNojEeC60axPepSq7g_1741520571.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how an option can be exercised.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionStyle4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__viXkNojEeC60axPepSq7g_1741520571")]
public partial class OptionStyle4CodeDropdownSource : EnumMetadataManager<OptionStyle4Code,IOptionStyle4CodeDropdownRow,OptionStyle4CodeDropdownRow>
{
    public OptionStyle4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionStyle4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
