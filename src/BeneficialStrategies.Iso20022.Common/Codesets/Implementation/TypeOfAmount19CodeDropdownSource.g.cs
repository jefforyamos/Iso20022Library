﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfAmount19Code.  ISO2002 ID# _or7VMPfKEei89sMSHxl1ew.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification or qualification of the type of amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfAmount19CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_or7VMPfKEei89sMSHxl1ew")]
public partial class TypeOfAmount19CodeDropdownSource : EnumMetadataManager<TypeOfAmount19Code,ITypeOfAmount19CodeDropdownRow,TypeOfAmount19CodeDropdownRow>
{
    public TypeOfAmount19CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfAmount19CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
