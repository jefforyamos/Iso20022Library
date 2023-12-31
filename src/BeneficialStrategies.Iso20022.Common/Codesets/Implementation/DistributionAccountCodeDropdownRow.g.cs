﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DistributionAccountCode.  ISO2002 ID# _1oiLwDL3EeKU9IrkkToqcw_-1432180896.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account where the disbursed CUSIP will be allocated.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DistributionAccountCodeDropdownSource"/>.
/// Implements <seealso cref="IDistributionAccountCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1oiLwDL3EeKU9IrkkToqcw_-1432180896")]
public partial class DistributionAccountCodeDropdownRow : EnumMetadataItem<DistributionAccountCode>, IDistributionAccountCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of account where the disbursed CUSIP will be allocated.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DistributionAccountCodeDropdownRow(DistributionAccountCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
