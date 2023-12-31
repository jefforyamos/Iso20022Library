﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FailureReason7Code.  ISO2002 ID# _q0qIka4LEeWZgJQOa6iKCQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Incident occurring during the processing of an ATM transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFailureReason7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_q0qIka4LEeWZgJQOa6iKCQ")]
public partial class FailureReason7CodeDropdownSource : EnumMetadataManager<FailureReason7Code,IFailureReason7CodeDropdownRow,FailureReason7CodeDropdownRow>
{
    public FailureReason7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FailureReason7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
