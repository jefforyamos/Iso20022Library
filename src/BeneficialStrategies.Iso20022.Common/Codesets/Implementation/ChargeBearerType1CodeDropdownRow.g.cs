﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChargeBearerType1Code.  ISO2002 ID# _a8PpINp-Ed-ak6NoX_4Aeg_940131843.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChargeBearerType1CodeDropdownSource"/>.
/// Implements <seealso cref="IChargeBearerType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a8PpINp-Ed-ak6NoX_4Aeg_940131843")]
public partial class ChargeBearerType1CodeDropdownRow : EnumMetadataItem<ChargeBearerType1Code>, IChargeBearerType1CodeDropdownRow
{
    /// <summary>
    /// Specifies which party(ies) will pay charges due for processing of the instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChargeBearerType1CodeDropdownRow(ChargeBearerType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
