﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OriginatorRoleCode.  ISO2002 ID# _Zw_W9tp-Ed-ak6NoX_4Aeg_141531855.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies in what capacity (role) the originator of a quote is acting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OriginatorRoleCodeDropdownSource"/>.
/// Implements <seealso cref="IOriginatorRoleCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zw_W9tp-Ed-ak6NoX_4Aeg_141531855")]
public partial class OriginatorRoleCodeDropdownRow : EnumMetadataItem<OriginatorRoleCode>, IOriginatorRoleCodeDropdownRow
{
    /// <summary>
    /// Specifies in what capacity (role) the originator of a quote is acting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OriginatorRoleCodeDropdownRow(OriginatorRoleCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
