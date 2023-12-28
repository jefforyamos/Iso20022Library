﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationRuleConfirmation1Code.  ISO2002 ID# _lfBx8CBpEeugLNJneiyzbA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the confirmation for the cross-element validation rules.
/// 
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationRuleConfirmation1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lfBx8CBpEeugLNJneiyzbA")]
public partial class ValidationRuleConfirmation1CodeDropdownSource : EnumMetadataManager<ValidationRuleConfirmation1Code,IValidationRuleConfirmation1CodeDropdownRow,ValidationRuleConfirmation1CodeDropdownRow>
{
    public ValidationRuleConfirmation1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationRuleConfirmation1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}