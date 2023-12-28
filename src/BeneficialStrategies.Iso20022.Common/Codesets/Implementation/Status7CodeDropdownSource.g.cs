﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Status7Code.  ISO2002 ID# _WMNrgF6uEeSyc4g_pm5hbw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction/vote.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatus7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WMNrgF6uEeSyc4g_pm5hbw")]
public partial class Status7CodeDropdownSource : EnumMetadataManager<Status7Code,IStatus7CodeDropdownRow,Status7CodeDropdownRow>
{
    public Status7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Status7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}