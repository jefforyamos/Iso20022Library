﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingFailingReason1Code.  ISO2002 ID# _4P-VgOkHEemm4qhb2yFPOw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingFailingReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4P-VgOkHEemm4qhb2yFPOw")]
public partial class PendingFailingReason1CodeDropdownSource : EnumMetadataManager<PendingFailingReason1Code,IPendingFailingReason1CodeDropdownRow,PendingFailingReason1CodeDropdownRow>
{
    public PendingFailingReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingFailingReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
