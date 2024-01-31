﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralStatusCode.  ISO2002 ID# _itEK0MUZEeiF-qqyf1JQhg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralStatusCodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_itEK0MUZEeiF-qqyf1JQhg")]
public partial class CollateralStatusCodeDropdownRow : EnumMetadataItem<CollateralStatusCode>, ICollateralStatusCodeDropdownRow
{
    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralStatusCodeDropdownRow(CollateralStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
