﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfPrice6Code.  ISO2002 ID# _YyQd0dp-Ed-ak6NoX_4Aeg_1990390335.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfPrice6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YyQd0dp-Ed-ak6NoX_4Aeg_1990390335")]
public partial class TypeOfPrice6CodeDropdownSource : EnumMetadataManager<TypeOfPrice6Code,ITypeOfPrice6CodeDropdownRow,TypeOfPrice6CodeDropdownRow>
{
    public TypeOfPrice6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfPrice6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
