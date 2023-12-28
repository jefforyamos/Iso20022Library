﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TypeOfPrice14Code.  ISO2002 ID# _Yx9i4Np-Ed-ak6NoX_4Aeg_-1404906082.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction price.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TypeOfPrice14CodeDropdownSource"/>.
/// Implements <seealso cref="ITypeOfPrice14CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yx9i4Np-Ed-ak6NoX_4Aeg_-1404906082")]
public partial class TypeOfPrice14CodeDropdownRow : EnumMetadataItem<TypeOfPrice14Code>, ITypeOfPrice14CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of transaction price.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TypeOfPrice14CodeDropdownRow(TypeOfPrice14Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}