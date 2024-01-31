﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfRequestCode.  ISO2002 ID# _92aNUNvdEeqxGfKJubfhIw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfRequestCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_92aNUNvdEeqxGfKJubfhIw")]
public partial class TypeOfRequestCodeDropdownSource : EnumMetadataManager<TypeOfRequestCode,ITypeOfRequestCodeDropdownRow,TypeOfRequestCodeDropdownRow>
{
    public TypeOfRequestCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfRequestCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
