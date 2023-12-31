﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionTypeCode.  ISO2002 ID# _aQbsBNp-Ed-ak6NoX_4Aeg_1247360713.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aQbsBNp-Ed-ak6NoX_4Aeg_1247360713")]
public partial class OptionTypeCodeDropdownSource : EnumMetadataManager<OptionTypeCode,IOptionTypeCodeDropdownRow,OptionTypeCodeDropdownRow>
{
    public OptionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
