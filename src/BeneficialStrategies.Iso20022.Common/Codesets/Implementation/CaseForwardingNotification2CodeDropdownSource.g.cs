﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CaseForwardingNotification2Code.  ISO2002 ID# _a2SLFNp-Ed-ak6NoX_4Aeg_-638403866.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action requested when forwarding a case. Assignees taking the decision to cancel or modify to further case assignees must communicate this decision to their case assigners.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICaseForwardingNotification2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a2SLFNp-Ed-ak6NoX_4Aeg_-638403866")]
public partial class CaseForwardingNotification2CodeDropdownSource : EnumMetadataManager<CaseForwardingNotification2Code,ICaseForwardingNotification2CodeDropdownRow,CaseForwardingNotification2CodeDropdownRow>
{
    public CaseForwardingNotification2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CaseForwardingNotification2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
