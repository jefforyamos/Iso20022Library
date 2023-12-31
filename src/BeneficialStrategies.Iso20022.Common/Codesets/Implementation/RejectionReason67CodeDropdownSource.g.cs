﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason67Code.  ISO2002 ID# _xqxxIBnzEeyroI8qKgB7Mg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason67CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xqxxIBnzEeyroI8qKgB7Mg")]
public partial class RejectionReason67CodeDropdownSource : EnumMetadataManager<RejectionReason67Code,IRejectionReason67CodeDropdownRow,RejectionReason67CodeDropdownRow>
{
    public RejectionReason67CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason67CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
