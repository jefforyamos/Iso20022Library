﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfAmount6Code.  ISO2002 ID# _WQhuYHs3EeSTS7uHCe8FPQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type or class of amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfAmount6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WQhuYHs3EeSTS7uHCe8FPQ")]
public partial class TypeOfAmount6CodeDropdownSource : EnumMetadataManager<TypeOfAmount6Code,ITypeOfAmount6CodeDropdownRow,TypeOfAmount6CodeDropdownRow>
{
    public TypeOfAmount6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfAmount6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
