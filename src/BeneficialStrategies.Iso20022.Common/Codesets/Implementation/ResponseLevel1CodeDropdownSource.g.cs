﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResponseLevel1Code.  ISO2002 ID# _ZVH6Udp-Ed-ak6NoX_4Aeg_-1599595783.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level of response requested from the receiver of the message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResponseLevel1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZVH6Udp-Ed-ak6NoX_4Aeg_-1599595783")]
public partial class ResponseLevel1CodeDropdownSource : EnumMetadataManager<ResponseLevel1Code,IResponseLevel1CodeDropdownRow,ResponseLevel1CodeDropdownRow>
{
    public ResponseLevel1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResponseLevel1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
