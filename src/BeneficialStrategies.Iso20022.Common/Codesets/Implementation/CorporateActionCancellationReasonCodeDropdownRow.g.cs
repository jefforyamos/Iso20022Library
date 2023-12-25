﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CorporateActionCancellationReasonCode.  ISO2002 ID# _bCpMFtp-Ed-ak6NoX_4Aeg_-484210840.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies reasons for cancellation of a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CorporateActionCancellationReasonCodeDropdownSource"/>.
/// Implements <seealso cref="ICorporateActionCancellationReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bCpMFtp-Ed-ak6NoX_4Aeg_-484210840")]
public partial class CorporateActionCancellationReasonCodeDropdownRow : EnumMetadataItem<CorporateActionCancellationReasonCode>, ICorporateActionCancellationReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies reasons for cancellation of a corporate action event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CorporateActionCancellationReasonCodeDropdownRow(CorporateActionCancellationReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
