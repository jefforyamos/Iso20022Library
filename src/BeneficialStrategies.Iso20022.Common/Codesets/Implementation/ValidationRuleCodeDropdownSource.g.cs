﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationRuleCode.  ISO2002 ID# _pQycwB8_EeuaqdhZaJ3GHw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies all codes that are to be used in the formal validation rules.
/// 
/// Usage: those codes must not be used in message definitions, as the code set is used when the formal validation rules make reference of an external code sets.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationRuleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pQycwB8_EeuaqdhZaJ3GHw")]
public partial class ValidationRuleCodeDropdownSource : EnumMetadataManager<ValidationRuleCode,IValidationRuleCodeDropdownRow,ValidationRuleCodeDropdownRow>
{
    public ValidationRuleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationRuleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
