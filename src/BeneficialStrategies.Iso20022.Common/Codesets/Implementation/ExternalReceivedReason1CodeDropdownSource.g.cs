﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalReceivedReason1Code.  ISO2002 ID# _BRBXUFjsEeOnqqBHs8Gasw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a received status.|
/// The list of valid codes is an external code list published separately. 
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalReceivedReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BRBXUFjsEeOnqqBHs8Gasw")]
public partial class ExternalReceivedReason1CodeDropdownSource : EnumMetadataManager<ExternalReceivedReason1Code,IExternalReceivedReason1CodeDropdownRow,ExternalReceivedReason1CodeDropdownRow>
{
    public ExternalReceivedReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalReceivedReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
