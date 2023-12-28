﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReinvestmentType1Code.  ISO2002 ID# _TstrIMkgEeeiAIB1i4AlQw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides details on the  type of the cash reinvestment in a given currency.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReinvestmentType1CodeDropdownSource"/>.
/// Implements <seealso cref="IReinvestmentType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TstrIMkgEeeiAIB1i4AlQw")]
public partial class ReinvestmentType1CodeDropdownRow : EnumMetadataItem<ReinvestmentType1Code>, IReinvestmentType1CodeDropdownRow
{
    /// <summary>
    /// Provides details on the  type of the cash reinvestment in a given currency.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReinvestmentType1CodeDropdownRow(ReinvestmentType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
