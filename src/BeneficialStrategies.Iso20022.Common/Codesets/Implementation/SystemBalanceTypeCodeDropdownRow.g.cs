﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SystemBalanceTypeCode.  ISO2002 ID# _8KMm4qMgEeCJ6YNENx4h-w_-228547867.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the system balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SystemBalanceTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ISystemBalanceTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8KMm4qMgEeCJ6YNENx4h-w_-228547867")]
public partial class SystemBalanceTypeCodeDropdownRow : EnumMetadataItem<SystemBalanceTypeCode>, ISystemBalanceTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the system balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SystemBalanceTypeCodeDropdownRow(SystemBalanceTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
