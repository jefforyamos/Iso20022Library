﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionDefinitionTypeCode.  ISO2002 ID# _ADxVkLcQEeKuGrOch6U_ZQ_1001230530.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionDefinitionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ADxVkLcQEeKuGrOch6U_ZQ_1001230530")]
public partial class OptionDefinitionTypeCodeDropdownSource : EnumMetadataManager<OptionDefinitionTypeCode,IOptionDefinitionTypeCodeDropdownRow,OptionDefinitionTypeCodeDropdownRow>
{
    public OptionDefinitionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionDefinitionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}