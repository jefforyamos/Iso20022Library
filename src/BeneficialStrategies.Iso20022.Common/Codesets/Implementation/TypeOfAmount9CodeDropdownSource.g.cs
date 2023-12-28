﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfAmount9Code.  ISO2002 ID# _dB5N0KHjEeagRbKvRt3LnA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfAmount9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dB5N0KHjEeagRbKvRt3LnA")]
public partial class TypeOfAmount9CodeDropdownSource : EnumMetadataManager<TypeOfAmount9Code,ITypeOfAmount9CodeDropdownRow,TypeOfAmount9CodeDropdownRow>
{
    public TypeOfAmount9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfAmount9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}