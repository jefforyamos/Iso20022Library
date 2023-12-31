﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalMarketInfrastructureCode.  ISO2002 ID# _MwrsIJ05Eeet_4BCDEBLdQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the market infrastructure identification, as published in an external market infrastructure code list.
/// This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalMarketInfrastructureCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MwrsIJ05Eeet_4BCDEBLdQ")]
public partial class ExternalMarketInfrastructureCodeDropdownSource : EnumMetadataManager<ExternalMarketInfrastructureCode,IExternalMarketInfrastructureCodeDropdownRow,ExternalMarketInfrastructureCodeDropdownRow>
{
    public ExternalMarketInfrastructureCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalMarketInfrastructureCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
