﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalMandateReason1Code.  ISO2002 ID# _ame0g9p-Ed-ak6NoX_4Aeg_-2059737298.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external mandate processing reason code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalMandateReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ame0g9p-Ed-ak6NoX_4Aeg_-2059737298")]
public partial class ExternalMandateReason1CodeDropdownSource : EnumMetadataManager<ExternalMandateReason1Code,IExternalMandateReason1CodeDropdownRow,ExternalMandateReason1CodeDropdownRow>
{
    public ExternalMandateReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalMandateReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
