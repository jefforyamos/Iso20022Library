﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationRuleRejected1Code.  ISO2002 ID# _S3XK8B-zEeuxStysDTgLiw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the rejected status code for the cross-element validation rules.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationRuleRejected1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_S3XK8B-zEeuxStysDTgLiw")]
public partial class ValidationRuleRejected1CodeDropdownSource : EnumMetadataManager<ValidationRuleRejected1Code,IValidationRuleRejected1CodeDropdownRow,ValidationRuleRejected1CodeDropdownRow>
{
    public ValidationRuleRejected1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationRuleRejected1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
