﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalValidationRuleIdentificationCode.  ISO2002 ID# _iwUTAGKIEeiw8ufheDd6MA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external validation rule identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalValidationRuleIdentificationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iwUTAGKIEeiw8ufheDd6MA")]
public partial class ExternalValidationRuleIdentificationCodeDropdownSource : EnumMetadataManager<ExternalValidationRuleIdentificationCode,IExternalValidationRuleIdentificationCodeDropdownRow,ExternalValidationRuleIdentificationCodeDropdownRow>
{
    public ExternalValidationRuleIdentificationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalValidationRuleIdentificationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
