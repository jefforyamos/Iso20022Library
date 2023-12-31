﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestigationExecutionConfirmationCode.  ISO2002 ID# _abdQQtp-Ed-ak6NoX_4Aeg_-1445551000.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the result of an investigation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestigationExecutionConfirmationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_abdQQtp-Ed-ak6NoX_4Aeg_-1445551000")]
public partial class InvestigationExecutionConfirmationCodeDropdownSource : EnumMetadataManager<InvestigationExecutionConfirmationCode,IInvestigationExecutionConfirmationCodeDropdownRow,InvestigationExecutionConfirmationCodeDropdownRow>
{
    public InvestigationExecutionConfirmationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestigationExecutionConfirmationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
