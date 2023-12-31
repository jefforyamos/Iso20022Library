﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfIdentification1Code.  ISO2002 ID# _YwnfFdp-Ed-ak6NoX_4Aeg_-1079654789.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfIdentification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YwnfFdp-Ed-ak6NoX_4Aeg_-1079654789")]
public partial class TypeOfIdentification1CodeDropdownSource : EnumMetadataManager<TypeOfIdentification1Code,ITypeOfIdentification1CodeDropdownRow,TypeOfIdentification1CodeDropdownRow>
{
    public TypeOfIdentification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfIdentification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
