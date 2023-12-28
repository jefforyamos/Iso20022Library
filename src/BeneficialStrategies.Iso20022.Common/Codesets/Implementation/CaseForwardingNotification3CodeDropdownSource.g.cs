﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CaseForwardingNotification3Code.  ISO2002 ID# _a2bVAtp-Ed-ak6NoX_4Aeg_-1716921082.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the action requested when forwarding a case.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICaseForwardingNotification3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a2bVAtp-Ed-ak6NoX_4Aeg_-1716921082")]
public partial class CaseForwardingNotification3CodeDropdownSource : EnumMetadataManager<CaseForwardingNotification3Code,ICaseForwardingNotification3CodeDropdownRow,CaseForwardingNotification3CodeDropdownRow>
{
    public CaseForwardingNotification3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CaseForwardingNotification3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}