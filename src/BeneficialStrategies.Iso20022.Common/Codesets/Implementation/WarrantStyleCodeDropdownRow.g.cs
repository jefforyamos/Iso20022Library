﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for WarrantStyleCode.  ISO2002 ID# _Yg0vmNp-Ed-ak6NoX_4Aeg_2120180285.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how a warrant can be exercised.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="WarrantStyleCodeDropdownSource"/>.
/// Implements <seealso cref="IWarrantStyleCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yg0vmNp-Ed-ak6NoX_4Aeg_2120180285")]
public partial class WarrantStyleCodeDropdownRow : EnumMetadataItem<WarrantStyleCode>, IWarrantStyleCodeDropdownRow
{
    /// <summary>
    /// Defines how a warrant can be exercised.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public WarrantStyleCodeDropdownRow(WarrantStyleCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}