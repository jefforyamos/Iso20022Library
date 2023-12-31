﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TypeOfPrice11Code.  ISO2002 ID# _YxNU8Np-Ed-ak6NoX_4Aeg_468430010.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TypeOfPrice11CodeDropdownSource"/>.
/// Implements <seealso cref="ITypeOfPrice11CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YxNU8Np-Ed-ak6NoX_4Aeg_468430010")]
public partial class TypeOfPrice11CodeDropdownRow : EnumMetadataItem<TypeOfPrice11Code>, ITypeOfPrice11CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TypeOfPrice11CodeDropdownRow(TypeOfPrice11Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
