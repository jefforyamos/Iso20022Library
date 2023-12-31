﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AcknowledgementReasonCode.  ISO2002 ID# _bpZDBtp-Ed-ak6NoX_4Aeg_423330067.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies additional information about the processed instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAcknowledgementReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bpZDBtp-Ed-ak6NoX_4Aeg_423330067")]
public partial class AcknowledgementReasonCodeDropdownSource : EnumMetadataManager<AcknowledgementReasonCode,IAcknowledgementReasonCodeDropdownRow,AcknowledgementReasonCodeDropdownRow>
{
    public AcknowledgementReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AcknowledgementReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
