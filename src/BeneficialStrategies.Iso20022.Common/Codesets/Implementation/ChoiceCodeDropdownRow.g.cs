﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChoiceCode.  ISO2002 ID# _a_OEoNp-Ed-ak6NoX_4Aeg_-798981296.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the separation of the security is optional or mandatory.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChoiceCodeDropdownSource"/>.
/// Implements <seealso cref="IChoiceCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a_OEoNp-Ed-ak6NoX_4Aeg_-798981296")]
public partial class ChoiceCodeDropdownRow : EnumMetadataItem<ChoiceCode>, IChoiceCodeDropdownRow
{
    /// <summary>
    /// Specifies if the separation of the security is optional or mandatory.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChoiceCodeDropdownRow(ChoiceCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}