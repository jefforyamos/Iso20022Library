﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalInformationTypeCode.  ISO2002 ID# _EroPkPeZEee0h5ZXun0VTA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the information type, as published in an external information type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalInformationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EroPkPeZEee0h5ZXun0VTA")]
public partial class ExternalInformationTypeCodeDropdownSource : EnumMetadataManager<ExternalInformationTypeCode,IExternalInformationTypeCodeDropdownRow,ExternalInformationTypeCodeDropdownRow>
{
    public ExternalInformationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalInformationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
