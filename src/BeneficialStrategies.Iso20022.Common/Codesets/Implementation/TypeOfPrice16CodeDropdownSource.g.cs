﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfPrice16Code.  ISO2002 ID# _Yx9i4tp-Ed-ak6NoX_4Aeg_-2021057381.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfPrice16CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yx9i4tp-Ed-ak6NoX_4Aeg_-2021057381")]
public partial class TypeOfPrice16CodeDropdownSource : EnumMetadataManager<TypeOfPrice16Code,ITypeOfPrice16CodeDropdownRow,TypeOfPrice16CodeDropdownRow>
{
    public TypeOfPrice16CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfPrice16CodeDropdownRow(enumValue, memberInfo))
    {
    }
}