﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason18Code.  ISO2002 ID# _U_0-vOXzEemEj48jhmlA0Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason18CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_U_0-vOXzEemEj48jhmlA0Q")]
public partial class PendingReason18CodeDropdownSource : EnumMetadataManager<PendingReason18Code,IPendingReason18CodeDropdownRow,PendingReason18CodeDropdownRow>
{
    public PendingReason18CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason18CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
