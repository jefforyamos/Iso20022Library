﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestigationExecutionConfirmation2Code.  ISO2002 ID# _aa3aZ9p-Ed-ak6NoX_4Aeg_-904367584.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the result of an investigation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestigationExecutionConfirmation2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aa3aZ9p-Ed-ak6NoX_4Aeg_-904367584")]
public partial class InvestigationExecutionConfirmation2CodeDropdownSource : EnumMetadataManager<InvestigationExecutionConfirmation2Code,IInvestigationExecutionConfirmation2CodeDropdownRow,InvestigationExecutionConfirmation2CodeDropdownRow>
{
    public InvestigationExecutionConfirmation2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestigationExecutionConfirmation2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
