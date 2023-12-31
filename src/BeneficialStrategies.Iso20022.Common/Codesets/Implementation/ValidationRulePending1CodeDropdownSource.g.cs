﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationRulePending1Code.  ISO2002 ID# _1q93Uh-0EeuxStysDTgLiw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the pending status code for the cross-element validation rules.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationRulePending1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1q93Uh-0EeuxStysDTgLiw")]
public partial class ValidationRulePending1CodeDropdownSource : EnumMetadataManager<ValidationRulePending1Code,IValidationRulePending1CodeDropdownRow,ValidationRulePending1CodeDropdownRow>
{
    public ValidationRulePending1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationRulePending1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
