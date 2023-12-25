﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalContractClosureReasonCode.  ISO2002 ID# _tDpx4JGAEeeBGrZP1w0opg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a contract closure reason code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalContractClosureReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tDpx4JGAEeeBGrZP1w0opg")]
public partial class ExternalContractClosureReasonCodeDropdownSource : EnumMetadataManager<ExternalContractClosureReasonCode,IExternalContractClosureReasonCodeDropdownRow,ExternalContractClosureReasonCodeDropdownRow>
{
    public ExternalContractClosureReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalContractClosureReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
