﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalRePresentmentReason1Code.  ISO2002 ID# _Y-8cBfwLEeGHDMP28rpT3g_-2028738047.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalRePresentmentReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y-8cBfwLEeGHDMP28rpT3g_-2028738047")]
public partial class ExternalRePresentmentReason1CodeDropdownSource : EnumMetadataManager<ExternalRePresentmentReason1Code,IExternalRePresentmentReason1CodeDropdownRow,ExternalRePresentmentReason1CodeDropdownRow>
{
    public ExternalRePresentmentReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalRePresentmentReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
