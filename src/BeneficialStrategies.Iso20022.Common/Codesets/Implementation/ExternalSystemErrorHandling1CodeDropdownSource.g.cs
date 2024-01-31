﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalSystemErrorHandling1Code.  ISO2002 ID# _Y2fRgnhdEeidzqjNEfehPg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the error code as generated by the system in the response, as published in an external balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalSystemErrorHandling1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y2fRgnhdEeidzqjNEfehPg")]
public partial class ExternalSystemErrorHandling1CodeDropdownSource : EnumMetadataManager<ExternalSystemErrorHandling1Code,IExternalSystemErrorHandling1CodeDropdownRow,ExternalSystemErrorHandling1CodeDropdownRow>
{
    public ExternalSystemErrorHandling1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalSystemErrorHandling1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
