﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestigationStatus1Code.  ISO2002 ID# _whTckFlIEeGYqvgbBHXAZw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of the investigation response related to a previously sent request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_whTckFlIEeGYqvgbBHXAZw")]
[Description(@"Provides the status of the investigation response related to a previously sent request.")]
[DerivedFrom(typeof(InvestigationStatusCode))]
public enum InvestigationStatus1Code
{
    /// <summary>
    /// Search for requested data is complete, the data has been found and will be sent using a separate message flow.
    /// Encoded/decoded by serializers as "DataFound".
    /// </summary>
    [EnumMember(Value = "FOUN")]
    [IsoId("_xZMG1llIEeGYqvgbBHXAZw")]
    [Description(@"Search for requested data is complete, the data has been found and will be sent using a separate message flow.")]
    DataFound,
    
    /// <summary>
    /// Search for requested data is complete, data not found.
    /// Encoded/decoded by serializers as "DataNotFound".
    /// </summary>
    [EnumMember(Value = "NFOU")]
    [IsoId("_xeGcBllIEeGYqvgbBHXAZw")]
    [Description(@"Search for requested data is complete, data not found.")]
    DataNotFound,
    
    /// <summary>
    /// Search for requested data not complete yet.
    /// Encoded/decoded by serializers as "NotApplicable".
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_xj6wJllIEeGYqvgbBHXAZw")]
    [Description(@"Search for requested data not complete yet.")]
    NotApplicable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestigationStatus1CodeMetadataExtensions
{
    private static readonly InvestigationStatus1CodeDropdownSource _dropdownSource = new InvestigationStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestigationStatus1CodeDropdownRow GetMetadata(this InvestigationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


