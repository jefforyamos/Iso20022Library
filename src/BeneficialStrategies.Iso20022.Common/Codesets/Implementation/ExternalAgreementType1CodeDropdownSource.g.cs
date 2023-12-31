﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalAgreementType1Code.  ISO2002 ID# _Jjlw8MkeEeeiAIB1i4AlQw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Name of the identification scheme, in a coded form as published in an external list.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalAgreementType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Jjlw8MkeEeeiAIB1i4AlQw")]
public partial class ExternalAgreementType1CodeDropdownSource : EnumMetadataManager<ExternalAgreementType1Code,IExternalAgreementType1CodeDropdownRow,ExternalAgreementType1CodeDropdownRow>
{
    public ExternalAgreementType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalAgreementType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
