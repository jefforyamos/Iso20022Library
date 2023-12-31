﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalInvestigationExecutionConfirmationCode.  ISO2002 ID# _RNLFpYmxEeeKR__nUfxjwA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of an investigation, as published in an external investigation execution confirmation code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalInvestigationExecutionConfirmationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RNLFpYmxEeeKR__nUfxjwA")]
public partial class ExternalInvestigationExecutionConfirmationCodeDropdownSource : EnumMetadataManager<ExternalInvestigationExecutionConfirmationCode,IExternalInvestigationExecutionConfirmationCodeDropdownRow,ExternalInvestigationExecutionConfirmationCodeDropdownRow>
{
    public ExternalInvestigationExecutionConfirmationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalInvestigationExecutionConfirmationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
