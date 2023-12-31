﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Gender1Code.  ISO2002 ID# _JyNe4IoTEeahcZ3Nzs1Qag.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the gender of a person.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGender1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JyNe4IoTEeahcZ3Nzs1Qag")]
public partial class Gender1CodeDropdownSource : EnumMetadataManager<Gender1Code,IGender1CodeDropdownRow,Gender1CodeDropdownRow>
{
    public Gender1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Gender1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
