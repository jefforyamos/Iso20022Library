﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason11Code.  ISO2002 ID# _ZgdAltp-Ed-ak6NoX_4Aeg_1782111527.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of the notification cancellation request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason11CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason11CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZgdAltp-Ed-ak6NoX_4Aeg_1782111527")]
public partial class RejectionReason11CodeDropdownRow : EnumMetadataItem<RejectionReason11Code>, IRejectionReason11CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason of a rejection of the notification cancellation request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason11CodeDropdownRow(RejectionReason11Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
