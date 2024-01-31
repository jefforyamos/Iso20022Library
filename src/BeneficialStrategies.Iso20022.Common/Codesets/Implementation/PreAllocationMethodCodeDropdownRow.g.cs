﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PreAllocationMethodCode.  ISO2002 ID# _aH73WNp-Ed-ak6NoX_4Aeg_616932935.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the method of preallocation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PreAllocationMethodCodeDropdownSource"/>.
/// Implements <seealso cref="IPreAllocationMethodCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aH73WNp-Ed-ak6NoX_4Aeg_616932935")]
public partial class PreAllocationMethodCodeDropdownRow : EnumMetadataItem<PreAllocationMethodCode>, IPreAllocationMethodCodeDropdownRow
{
    /// <summary>
    /// Indicates the method of preallocation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PreAllocationMethodCodeDropdownRow(PreAllocationMethodCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
