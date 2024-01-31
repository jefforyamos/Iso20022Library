﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationRuleInstruction1Code.  ISO2002 ID# _cCdYNCAZEeuxStysDTgLiw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the instruction for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationRuleInstruction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cCdYNCAZEeuxStysDTgLiw")]
public partial class ValidationRuleInstruction1CodeDropdownSource : EnumMetadataManager<ValidationRuleInstruction1Code,IValidationRuleInstruction1CodeDropdownRow,ValidationRuleInstruction1CodeDropdownRow>
{
    public ValidationRuleInstruction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationRuleInstruction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
