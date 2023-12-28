﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TypeOfAmount1Code.  ISO2002 ID# _TUJ9MwEcEeCQm6a_G2yO_w_-427781044.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualifies the amount associated with the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TypeOfAmount1CodeDropdownSource"/>.
/// Implements <seealso cref="ITypeOfAmount1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TUJ9MwEcEeCQm6a_G2yO_w_-427781044")]
public partial class TypeOfAmount1CodeDropdownRow : EnumMetadataItem<TypeOfAmount1Code>, ITypeOfAmount1CodeDropdownRow
{
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TypeOfAmount1CodeDropdownRow(TypeOfAmount1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
