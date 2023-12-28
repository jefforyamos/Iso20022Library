﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason11Code.  ISO2002 ID# _dc-9MCdcEeOXAt_43VmZGw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason11CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dc-9MCdcEeOXAt_43VmZGw")]
public partial class PendingReason11CodeDropdownSource : EnumMetadataManager<PendingReason11Code,IPendingReason11CodeDropdownRow,PendingReason11CodeDropdownRow>
{
    public PendingReason11CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason11CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
