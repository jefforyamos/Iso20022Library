﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ValidationRuleIssuanceType1Code.  ISO2002 ID# _rW7kBCBqEeugLNJneiyzbA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the instruction for the cross-element validation rules.
/// 
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ValidationRuleIssuanceType1CodeDropdownSource"/>.
/// Implements <seealso cref="IValidationRuleIssuanceType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rW7kBCBqEeugLNJneiyzbA")]
public partial class ValidationRuleIssuanceType1CodeDropdownRow : EnumMetadataItem<ValidationRuleIssuanceType1Code>, IValidationRuleIssuanceType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the instruction for the cross-element validation rules.
    /// 
    /// Usage: the code set is used when the formal validation rules make reference of an external code sets.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ValidationRuleIssuanceType1CodeDropdownRow(ValidationRuleIssuanceType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
