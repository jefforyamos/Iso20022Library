﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AllegementStatusCode.  ISO2002 ID# _bopcI9p-Ed-ak6NoX_4Aeg_241665691.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an allegement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAllegementStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bopcI9p-Ed-ak6NoX_4Aeg_241665691")]
public partial class AllegementStatusCodeDropdownSource : EnumMetadataManager<AllegementStatusCode,IAllegementStatusCodeDropdownRow,AllegementStatusCodeDropdownRow>
{
    public AllegementStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AllegementStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
