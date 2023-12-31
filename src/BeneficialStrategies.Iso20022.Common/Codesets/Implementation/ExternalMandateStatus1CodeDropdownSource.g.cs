﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalMandateStatus1Code.  ISO2002 ID# _qC1AgJm_Eeao_Z127E9uYg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external mandate status code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalMandateStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qC1AgJm_Eeao_Z127E9uYg")]
public partial class ExternalMandateStatus1CodeDropdownSource : EnumMetadataManager<ExternalMandateStatus1Code,IExternalMandateStatus1CodeDropdownRow,ExternalMandateStatus1CodeDropdownRow>
{
    public ExternalMandateStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalMandateStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
