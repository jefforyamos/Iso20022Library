﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OperatorCode.  ISO2002 ID# _aPPZMNp-Ed-ak6NoX_4Aeg_336257296.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code containing the operator used to indicate the relationship between a variable and a fixed value.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OperatorCodeDropdownSource"/>.
/// Implements <seealso cref="IOperatorCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aPPZMNp-Ed-ak6NoX_4Aeg_336257296")]
public partial class OperatorCodeDropdownRow : EnumMetadataItem<OperatorCode>, IOperatorCodeDropdownRow
{
    /// <summary>
    /// Code containing the operator used to indicate the relationship between a variable and a fixed value.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OperatorCodeDropdownRow(OperatorCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
