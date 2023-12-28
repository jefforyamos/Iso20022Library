﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Operator1Code.  ISO2002 ID# _aPFoM9p-Ed-ak6NoX_4Aeg_1632624571.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code containing the operator used to indicate the relationship between a variable and a fixed value.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Operator1CodeDropdownSource"/>.
/// Implements <seealso cref="IOperator1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aPFoM9p-Ed-ak6NoX_4Aeg_1632624571")]
public partial class Operator1CodeDropdownRow : EnumMetadataItem<Operator1Code>, IOperator1CodeDropdownRow
{
    /// <summary>
    /// Code containing the operator used to indicate the relationship between a variable and a fixed value.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Operator1CodeDropdownRow(Operator1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}