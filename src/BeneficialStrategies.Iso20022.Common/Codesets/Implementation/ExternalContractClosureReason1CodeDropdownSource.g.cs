﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalContractClosureReason1Code.  ISO2002 ID# _9dPfkQrAEeWD-cmAqruRjw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a contract closure reason code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalContractClosureReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9dPfkQrAEeWD-cmAqruRjw")]
public partial class ExternalContractClosureReason1CodeDropdownSource : EnumMetadataManager<ExternalContractClosureReason1Code,IExternalContractClosureReason1CodeDropdownRow,ExternalContractClosureReason1CodeDropdownRow>
{
    public ExternalContractClosureReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalContractClosureReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}