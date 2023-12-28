﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RequestModeType1Code.  ISO2002 ID# _rDVVUMm4EeWAGphE2LvqeA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the combination of mode and type of the query information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRequestModeType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rDVVUMm4EeWAGphE2LvqeA")]
public partial class RequestModeType1CodeDropdownSource : EnumMetadataManager<RequestModeType1Code,IRequestModeType1CodeDropdownRow,RequestModeType1CodeDropdownRow>
{
    public RequestModeType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RequestModeType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
