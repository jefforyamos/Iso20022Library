﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PegType1Code.  ISO2002 ID# _Z9p599p-Ed-ak6NoX_4Aeg_307440382.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates a type of instruction to a broker or dealer to buy or sell a financial instrument which is pegged against a certain value.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PegType1CodeDropdownSource"/>.
/// Implements <seealso cref="IPegType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z9p599p-Ed-ak6NoX_4Aeg_307440382")]
public partial class PegType1CodeDropdownRow : EnumMetadataItem<PegType1Code>, IPegType1CodeDropdownRow
{
    /// <summary>
    /// Indicates a type of instruction to a broker or dealer to buy or sell a financial instrument which is pegged against a certain value.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PegType1CodeDropdownRow(PegType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}