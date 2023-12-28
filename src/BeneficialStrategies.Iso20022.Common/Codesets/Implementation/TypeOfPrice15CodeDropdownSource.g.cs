﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfPrice15Code.  ISO2002 ID# _WOMlo9p-Ed-ak6NoX_4Aeg_1777611092.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfPrice15CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WOMlo9p-Ed-ak6NoX_4Aeg_1777611092")]
public partial class TypeOfPrice15CodeDropdownSource : EnumMetadataManager<TypeOfPrice15Code,ITypeOfPrice15CodeDropdownRow,TypeOfPrice15CodeDropdownRow>
{
    public TypeOfPrice15CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfPrice15CodeDropdownRow(enumValue, memberInfo))
    {
    }
}