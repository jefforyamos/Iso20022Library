﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfPrice7Code.  ISO2002 ID# _Vgl4xtp-Ed-ak6NoX_4Aeg_1127883385.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfPrice7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vgl4xtp-Ed-ak6NoX_4Aeg_1127883385")]
public partial class TypeOfPrice7CodeDropdownSource : EnumMetadataManager<TypeOfPrice7Code,ITypeOfPrice7CodeDropdownRow,TypeOfPrice7CodeDropdownRow>
{
    public TypeOfPrice7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfPrice7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
