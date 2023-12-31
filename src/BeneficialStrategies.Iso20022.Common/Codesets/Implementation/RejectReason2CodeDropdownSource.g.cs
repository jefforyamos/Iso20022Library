﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectReason2Code.  ISO2002 ID# _QF27QWp1EeSMqvBfBY1c9A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason of transmission of a rejection message in response to a request or an advice.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QF27QWp1EeSMqvBfBY1c9A")]
public partial class RejectReason2CodeDropdownSource : EnumMetadataManager<RejectReason2Code,IRejectReason2CodeDropdownRow,RejectReason2CodeDropdownRow>
{
    public RejectReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
