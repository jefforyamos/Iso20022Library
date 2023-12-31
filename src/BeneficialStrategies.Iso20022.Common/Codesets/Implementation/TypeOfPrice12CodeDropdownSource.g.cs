﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfPrice12Code.  ISO2002 ID# _Yxg28Np-Ed-ak6NoX_4Aeg_-254159336.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfPrice12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yxg28Np-Ed-ak6NoX_4Aeg_-254159336")]
public partial class TypeOfPrice12CodeDropdownSource : EnumMetadataManager<TypeOfPrice12Code,ITypeOfPrice12CodeDropdownRow,TypeOfPrice12CodeDropdownRow>
{
    public TypeOfPrice12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfPrice12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
