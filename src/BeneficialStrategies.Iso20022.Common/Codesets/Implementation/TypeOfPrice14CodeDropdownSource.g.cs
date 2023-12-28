﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfPrice14Code.  ISO2002 ID# _Yx9i4Np-Ed-ak6NoX_4Aeg_-1404906082.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfPrice14CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yx9i4Np-Ed-ak6NoX_4Aeg_-1404906082")]
public partial class TypeOfPrice14CodeDropdownSource : EnumMetadataManager<TypeOfPrice14Code,ITypeOfPrice14CodeDropdownRow,TypeOfPrice14CodeDropdownRow>
{
    public TypeOfPrice14CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfPrice14CodeDropdownRow(enumValue, memberInfo))
    {
    }
}