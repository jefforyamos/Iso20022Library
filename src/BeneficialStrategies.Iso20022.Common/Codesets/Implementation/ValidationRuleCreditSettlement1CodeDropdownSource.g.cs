﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationRuleCreditSettlement1Code.  ISO2002 ID# _el78sCE5EeuIZ4Hf6difAw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the accepted credit settlement completed status code for the cross-element validation rules.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationRuleCreditSettlement1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_el78sCE5EeuIZ4Hf6difAw")]
public partial class ValidationRuleCreditSettlement1CodeDropdownSource : EnumMetadataManager<ValidationRuleCreditSettlement1Code,IValidationRuleCreditSettlement1CodeDropdownRow,ValidationRuleCreditSettlement1CodeDropdownRow>
{
    public ValidationRuleCreditSettlement1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationRuleCreditSettlement1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
