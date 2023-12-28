﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AcknowledgementReason1Code.  ISO2002 ID# _bo8XFdp-Ed-ak6NoX_4Aeg_1078227922.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies additional information about the processed instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAcknowledgementReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bo8XFdp-Ed-ak6NoX_4Aeg_1078227922")]
public partial class AcknowledgementReason1CodeDropdownSource : EnumMetadataManager<AcknowledgementReason1Code,IAcknowledgementReason1CodeDropdownRow,AcknowledgementReason1CodeDropdownRow>
{
    public AcknowledgementReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AcknowledgementReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
