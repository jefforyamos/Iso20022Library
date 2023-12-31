﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CaseForwardingNotification2Code.  ISO2002 ID# _a2SLFNp-Ed-ak6NoX_4Aeg_-638403866.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the action requested when forwarding a case. Assignees taking the decision to cancel or modify to further case assignees must communicate this decision to their case assigners.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CaseForwardingNotification2CodeDropdownSource"/>.
/// Implements <seealso cref="ICaseForwardingNotification2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a2SLFNp-Ed-ak6NoX_4Aeg_-638403866")]
public partial class CaseForwardingNotification2CodeDropdownRow : EnumMetadataItem<CaseForwardingNotification2Code>, ICaseForwardingNotification2CodeDropdownRow
{
    /// <summary>
    /// Specifies the action requested when forwarding a case. Assignees taking the decision to cancel or modify to further case assignees must communicate this decision to their case assigners.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CaseForwardingNotification2CodeDropdownRow(CaseForwardingNotification2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
