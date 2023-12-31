﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MandateReasonCode.  ISO2002 ID# _af7gkNp-Ed-ak6NoX_4Aeg_-586944687.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for requesting the amendment or cancellation of a mandate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MandateReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IMandateReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_af7gkNp-Ed-ak6NoX_4Aeg_-586944687")]
public partial class MandateReasonCodeDropdownRow : EnumMetadataItem<MandateReasonCode>, IMandateReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for requesting the amendment or cancellation of a mandate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MandateReasonCodeDropdownRow(MandateReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
