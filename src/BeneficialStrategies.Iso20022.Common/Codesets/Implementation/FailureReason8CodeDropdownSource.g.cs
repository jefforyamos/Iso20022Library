﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FailureReason8Code.  ISO2002 ID# _oMx7AK5FEeWCgYcWSNgX5g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Exception occurring outside the service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFailureReason8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_oMx7AK5FEeWCgYcWSNgX5g")]
public partial class FailureReason8CodeDropdownSource : EnumMetadataManager<FailureReason8Code,IFailureReason8CodeDropdownRow,FailureReason8CodeDropdownRow>
{
    public FailureReason8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FailureReason8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}