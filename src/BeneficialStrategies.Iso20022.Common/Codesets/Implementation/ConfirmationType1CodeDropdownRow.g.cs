﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ConfirmationType1Code.  ISO2002 ID# _VirjeNp-Ed-ak6NoX_4Aeg_1065163158.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ConfirmationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IConfirmationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VirjeNp-Ed-ak6NoX_4Aeg_1065163158")]
public partial class ConfirmationType1CodeDropdownRow : EnumMetadataItem<ConfirmationType1Code>, IConfirmationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ConfirmationType1CodeDropdownRow(ConfirmationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
