﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalAcceptedReason1Code.  ISO2002 ID# _fNkVgFjqEeOnqqBHs8Gasw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for an accepted status.|
/// The list of valid codes is an external code list published separately. 
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalAcceptedReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fNkVgFjqEeOnqqBHs8Gasw")]
public partial class ExternalAcceptedReason1CodeDropdownSource : EnumMetadataManager<ExternalAcceptedReason1Code,IExternalAcceptedReason1CodeDropdownRow,ExternalAcceptedReason1CodeDropdownRow>
{
    public ExternalAcceptedReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalAcceptedReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}