﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MandateCancellationReason1Code.  ISO2002 ID# _afxvk9p-Ed-ak6NoX_4Aeg_1808299686.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for requesting the cancellation of a mandate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMandateCancellationReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_afxvk9p-Ed-ak6NoX_4Aeg_1808299686")]
public partial class MandateCancellationReason1CodeDropdownSource : EnumMetadataManager<MandateCancellationReason1Code,IMandateCancellationReason1CodeDropdownRow,MandateCancellationReason1CodeDropdownRow>
{
    public MandateCancellationReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MandateCancellationReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
