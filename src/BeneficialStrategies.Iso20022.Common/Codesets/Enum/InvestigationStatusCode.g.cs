﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestigationStatusCode.  ISO2002 ID# __-fWcz_lEeGQnbmlZjr_fQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of the investigation response related to a previously sent request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__-fWcz_lEeGQnbmlZjr_fQ")]
[Description(@"Provides the status of the investigation response related to a previously sent request.")]
public enum InvestigationStatusCode
{
    /// <summary>
    /// Search for requested data is complete, the data has been found and will be sent using a separate message flow.
    /// Encoded/decoded by serializers as "FOUN".
    /// </summary>
    [EnumMember(Value = "FOUN")]
    [IsoId("_Ksjbpz_mEeGQnbmlZjr_fQ")]
    [Description(@"Search for requested data is complete, the data has been found and will be sent using a separate message flow.")]
    DataFound,
    
    /// <summary>
    /// Search for requested data is complete, data not found.
    /// Encoded/decoded by serializers as "NFOU".
    /// </summary>
    [EnumMember(Value = "NFOU")]
    [IsoId("_YnWilz_mEeGQnbmlZjr_fQ")]
    [Description(@"Search for requested data is complete, data not found.")]
    DataNotFound,
    
    /// <summary>
    /// Search for requested data not complete yet.
    /// Encoded/decoded by serializers as "NOAP".
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_szJtjT_mEeGQnbmlZjr_fQ")]
    [Description(@"Search for requested data not complete yet.")]
    NotApplicable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestigationStatusCodeMetadataExtensions
{
    private static readonly InvestigationStatusCodeDropdownSource _dropdownSource = new InvestigationStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestigationStatusCodeDropdownRow GetMetadata(this InvestigationStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


