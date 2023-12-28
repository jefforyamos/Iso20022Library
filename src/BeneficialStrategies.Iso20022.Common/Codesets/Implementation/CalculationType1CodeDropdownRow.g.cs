﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CalculationType1Code.  ISO2002 ID# _bVa-Jtp-Ed-ak6NoX_4Aeg_-2002254762.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the yield computation method.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CalculationType1CodeDropdownSource"/>.
/// Implements <seealso cref="ICalculationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bVa-Jtp-Ed-ak6NoX_4Aeg_-2002254762")]
public partial class CalculationType1CodeDropdownRow : EnumMetadataItem<CalculationType1Code>, ICalculationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the yield computation method.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CalculationType1CodeDropdownRow(CalculationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}