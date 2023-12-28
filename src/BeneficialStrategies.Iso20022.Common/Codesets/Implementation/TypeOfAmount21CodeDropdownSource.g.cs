﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfAmount21Code.  ISO2002 ID# _EG1A4aH_EeuiuNcvKhXmNQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type or class of amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfAmount21CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EG1A4aH_EeuiuNcvKhXmNQ")]
public partial class TypeOfAmount21CodeDropdownSource : EnumMetadataManager<TypeOfAmount21Code,ITypeOfAmount21CodeDropdownRow,TypeOfAmount21CodeDropdownRow>
{
    public TypeOfAmount21CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfAmount21CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
