﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfAmount7Code.  ISO2002 ID# _JO5DMIN-EeSNofOeou9G3A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type or class of amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfAmount7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JO5DMIN-EeSNofOeou9G3A")]
public partial class TypeOfAmount7CodeDropdownSource : EnumMetadataManager<TypeOfAmount7Code,ITypeOfAmount7CodeDropdownRow,TypeOfAmount7CodeDropdownRow>
{
    public TypeOfAmount7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfAmount7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
