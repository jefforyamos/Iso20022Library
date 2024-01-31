﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationRuleReceived1Code.  ISO2002 ID# _1VeIch-0EeuxStysDTgLiw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the received status for the cross-element validation rules.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationRuleReceived1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1VeIch-0EeuxStysDTgLiw")]
public partial class ValidationRuleReceived1CodeDropdownSource : EnumMetadataManager<ValidationRuleReceived1Code,IValidationRuleReceived1CodeDropdownRow,ValidationRuleReceived1CodeDropdownRow>
{
    public ValidationRuleReceived1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationRuleReceived1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
