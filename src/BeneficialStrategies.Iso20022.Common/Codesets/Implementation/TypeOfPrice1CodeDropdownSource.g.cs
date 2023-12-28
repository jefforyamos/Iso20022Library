﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfPrice1Code.  ISO2002 ID# _Yx9i5dp-Ed-ak6NoX_4Aeg_-1302250885.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfPrice1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yx9i5dp-Ed-ak6NoX_4Aeg_-1302250885")]
public partial class TypeOfPrice1CodeDropdownSource : EnumMetadataManager<TypeOfPrice1Code,ITypeOfPrice1CodeDropdownRow,TypeOfPrice1CodeDropdownRow>
{
    public TypeOfPrice1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfPrice1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
