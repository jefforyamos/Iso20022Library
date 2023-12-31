﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdditionalServiceResult1Code.  ISO2002 ID# _Pw460J1KEeublrfU-wN95w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the result of the service performed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdditionalServiceResult1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Pw460J1KEeublrfU-wN95w")]
public partial class AdditionalServiceResult1CodeDropdownSource : EnumMetadataManager<AdditionalServiceResult1Code,IAdditionalServiceResult1CodeDropdownRow,AdditionalServiceResult1CodeDropdownRow>
{
    public AdditionalServiceResult1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdditionalServiceResult1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
