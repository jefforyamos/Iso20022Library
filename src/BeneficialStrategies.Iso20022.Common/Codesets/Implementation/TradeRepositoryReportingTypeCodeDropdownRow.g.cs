﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeRepositoryReportingTypeCode.  ISO2002 ID# _gIoLANIFEeiG-o-KpBT4-g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indication whether both counterparties to the transaction have reported to the same trade repository or each counteraprty to the transaction reported two different trade repository.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeRepositoryReportingTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ITradeRepositoryReportingTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gIoLANIFEeiG-o-KpBT4-g")]
public partial class TradeRepositoryReportingTypeCodeDropdownRow : EnumMetadataItem<TradeRepositoryReportingTypeCode>, ITradeRepositoryReportingTypeCodeDropdownRow
{
    /// <summary>
    /// Indication whether both counterparties to the transaction have reported to the same trade repository or each counteraprty to the transaction reported two different trade repository.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeRepositoryReportingTypeCodeDropdownRow(TradeRepositoryReportingTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
