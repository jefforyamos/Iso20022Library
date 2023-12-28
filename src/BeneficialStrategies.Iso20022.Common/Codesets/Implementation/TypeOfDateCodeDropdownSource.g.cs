﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfDateCode.  ISO2002 ID# _Oxs3y2-BEeKuY41pq1-dog.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a date is actual or estimated.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfDateCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Oxs3y2-BEeKuY41pq1-dog")]
public partial class TypeOfDateCodeDropdownSource : EnumMetadataManager<TypeOfDateCode,ITypeOfDateCodeDropdownRow,TypeOfDateCodeDropdownRow>
{
    public TypeOfDateCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfDateCodeDropdownRow(enumValue, memberInfo))
    {
    }
}