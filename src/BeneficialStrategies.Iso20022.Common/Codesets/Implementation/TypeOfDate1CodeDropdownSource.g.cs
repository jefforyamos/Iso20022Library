﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfDate1Code.  ISO2002 ID# _TVs0sFfvEeOuDtoQo1qilA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a date is actual or estimated.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfDate1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVs0sFfvEeOuDtoQo1qilA")]
public partial class TypeOfDate1CodeDropdownSource : EnumMetadataManager<TypeOfDate1Code,ITypeOfDate1CodeDropdownRow,TypeOfDate1CodeDropdownRow>
{
    public TypeOfDate1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfDate1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
