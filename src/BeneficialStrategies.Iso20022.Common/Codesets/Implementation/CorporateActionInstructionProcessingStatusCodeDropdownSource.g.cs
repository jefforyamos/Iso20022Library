﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionInstructionProcessingStatusCode.  ISO2002 ID# _bKjK4dp-Ed-ak6NoX_4Aeg_-1308410939.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a corporate action instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionInstructionProcessingStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bKjK4dp-Ed-ak6NoX_4Aeg_-1308410939")]
public partial class CorporateActionInstructionProcessingStatusCodeDropdownSource : EnumMetadataManager<CorporateActionInstructionProcessingStatusCode,ICorporateActionInstructionProcessingStatusCodeDropdownRow,CorporateActionInstructionProcessingStatusCodeDropdownRow>
{
    public CorporateActionInstructionProcessingStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionInstructionProcessingStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
