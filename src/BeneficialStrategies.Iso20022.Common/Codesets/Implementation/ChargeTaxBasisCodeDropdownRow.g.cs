﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChargeTaxBasisCode.  ISO2002 ID# __1DJsdojEeC60axPepSq7g_143503788.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Define the Charges/tax basis for the trade being allocated.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChargeTaxBasisCodeDropdownSource"/>.
/// Implements <seealso cref="IChargeTaxBasisCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__1DJsdojEeC60axPepSq7g_143503788")]
public partial class ChargeTaxBasisCodeDropdownRow : EnumMetadataItem<ChargeTaxBasisCode>, IChargeTaxBasisCodeDropdownRow
{
    /// <summary>
    /// Define the Charges/tax basis for the trade being allocated.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChargeTaxBasisCodeDropdownRow(ChargeTaxBasisCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
