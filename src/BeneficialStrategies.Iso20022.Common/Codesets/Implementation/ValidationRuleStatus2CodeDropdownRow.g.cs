﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ValidationRuleStatus2Code.  ISO2002 ID# _RDOJRh-yEeuxStysDTgLiw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ValidationRuleStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="IValidationRuleStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RDOJRh-yEeuxStysDTgLiw")]
public partial class ValidationRuleStatus2CodeDropdownRow : EnumMetadataItem<ValidationRuleStatus2Code>, IValidationRuleStatus2CodeDropdownRow
{
    /// <summary>
    /// Specifies the status for the cross-element validation rules.
    /// Usage: the code set is used when the formal validation rules make reference of an external code sets.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ValidationRuleStatus2CodeDropdownRow(ValidationRuleStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
