﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NetworkTypeCode.  ISO2002 ID# _Wl2EAGpVEeSR-ZWLvO-1dg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of communication network.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INetworkTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Wl2EAGpVEeSR-ZWLvO-1dg")]
public partial class NetworkTypeCodeDropdownSource : EnumMetadataManager<NetworkTypeCode,INetworkTypeCodeDropdownRow,NetworkTypeCodeDropdownRow>
{
    public NetworkTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NetworkTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
