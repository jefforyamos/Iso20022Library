﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason62Code.  ISO2002 ID# _RZnBUhIvEeyHZKWo4KVxBw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the transaction or in the instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason62CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RZnBUhIvEeyHZKWo4KVxBw")]
public partial class RejectionReason62CodeDropdownSource : EnumMetadataManager<RejectionReason62Code,IRejectionReason62CodeDropdownRow,RejectionReason62CodeDropdownRow>
{
    public RejectionReason62CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason62CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
