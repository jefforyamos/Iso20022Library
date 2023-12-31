﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfIdentification2Code.  ISO2002 ID# __ztF49ojEeC60axPepSq7g_97735513.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfIdentification2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__ztF49ojEeC60axPepSq7g_97735513")]
public partial class TypeOfIdentification2CodeDropdownSource : EnumMetadataManager<TypeOfIdentification2Code,ITypeOfIdentification2CodeDropdownRow,TypeOfIdentification2CodeDropdownRow>
{
    public TypeOfIdentification2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfIdentification2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
