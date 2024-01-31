﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DetailAmountCode.  ISO2002 ID# _BM4rsBbxEeit0dtP9bTmEg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of detail amount
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DetailAmountCodeDropdownSource"/>.
/// Implements <seealso cref="IDetailAmountCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BM4rsBbxEeit0dtP9bTmEg")]
public partial class DetailAmountCodeDropdownRow : EnumMetadataItem<DetailAmountCode>, IDetailAmountCodeDropdownRow
{
    /// <summary>
    /// Type of detail amount
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DetailAmountCodeDropdownRow(DetailAmountCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
