﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PensionSchemeType3Code.  ISO2002 ID# _ufPCkelpEeuvhrZwLF0fDg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of pension scheme.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPensionSchemeType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ufPCkelpEeuvhrZwLF0fDg")]
public partial class PensionSchemeType3CodeDropdownSource : EnumMetadataManager<PensionSchemeType3Code,IPensionSchemeType3CodeDropdownRow,PensionSchemeType3CodeDropdownRow>
{
    public PensionSchemeType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PensionSchemeType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
