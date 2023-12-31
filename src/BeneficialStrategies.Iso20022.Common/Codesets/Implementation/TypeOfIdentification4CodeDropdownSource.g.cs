﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfIdentification4Code.  ISO2002 ID# _RoFDgI6CEemzmeK8_tPygg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfIdentification4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RoFDgI6CEemzmeK8_tPygg")]
public partial class TypeOfIdentification4CodeDropdownSource : EnumMetadataManager<TypeOfIdentification4Code,ITypeOfIdentification4CodeDropdownRow,TypeOfIdentification4CodeDropdownRow>
{
    public TypeOfIdentification4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfIdentification4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
