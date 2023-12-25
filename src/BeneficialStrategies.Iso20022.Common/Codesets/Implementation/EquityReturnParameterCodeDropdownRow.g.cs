﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EquityReturnParameterCode.  ISO2002 ID# _E3W44QneEeWa7rBfPECYsw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an equity derivative return parameter.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EquityReturnParameterCodeDropdownSource"/>.
/// Implements <seealso cref="IEquityReturnParameterCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_E3W44QneEeWa7rBfPECYsw")]
public partial class EquityReturnParameterCodeDropdownRow : EnumMetadataItem<EquityReturnParameterCode>, IEquityReturnParameterCodeDropdownRow
{
    /// <summary>
    /// Specifies an equity derivative return parameter.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EquityReturnParameterCodeDropdownRow(EquityReturnParameterCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
