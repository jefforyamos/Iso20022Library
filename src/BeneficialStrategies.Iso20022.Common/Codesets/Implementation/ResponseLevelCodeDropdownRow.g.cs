﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ResponseLevelCode.  ISO2002 ID# _ZVH6Vdp-Ed-ak6NoX_4Aeg_336259036.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of response requested from the receiver of the message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ResponseLevelCodeDropdownSource"/>.
/// Implements <seealso cref="IResponseLevelCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZVH6Vdp-Ed-ak6NoX_4Aeg_336259036")]
public partial class ResponseLevelCodeDropdownRow : EnumMetadataItem<ResponseLevelCode>, IResponseLevelCodeDropdownRow
{
    /// <summary>
    /// Specifies the level of response requested from the receiver of the message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ResponseLevelCodeDropdownRow(ResponseLevelCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
