﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InterestComputationMethodCode.  ISO2002 ID# _aZrHltp-Ed-ak6NoX_4Aeg_1988747412.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to compute accruing interest of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InterestComputationMethodCodeDropdownSource"/>.
/// Implements <seealso cref="IInterestComputationMethodCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aZrHltp-Ed-ak6NoX_4Aeg_1988747412")]
public partial class InterestComputationMethodCodeDropdownRow : EnumMetadataItem<InterestComputationMethodCode>, IInterestComputationMethodCodeDropdownRow
{
    /// <summary>
    /// Specifies the method used to compute accruing interest of a financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InterestComputationMethodCodeDropdownRow(InterestComputationMethodCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
