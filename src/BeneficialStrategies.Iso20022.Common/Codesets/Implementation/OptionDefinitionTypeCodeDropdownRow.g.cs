﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OptionDefinitionTypeCode.  ISO2002 ID# _ADxVkLcQEeKuGrOch6U_ZQ_1001230530.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OptionDefinitionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IOptionDefinitionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ADxVkLcQEeKuGrOch6U_ZQ_1001230530")]
public partial class OptionDefinitionTypeCodeDropdownRow : EnumMetadataItem<OptionDefinitionTypeCode>, IOptionDefinitionTypeCodeDropdownRow
{
    /// <summary>
    /// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OptionDefinitionTypeCodeDropdownRow(OptionDefinitionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
