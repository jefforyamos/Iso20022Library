﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BaselineStatus3Code.  ISO2002 ID# _bcugAtp-Ed-ak6NoX_4Aeg_-310506131.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of a baseline.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bcugAtp-Ed-ak6NoX_4Aeg_-310506131")]
[Description(@"Indicates the status of a baseline.")]
[DerivedFrom(typeof(BaselineStatusCode))]
public enum BaselineStatus3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Proposed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bcugA9p-Ed-ak6NoX_4Aeg_-310506101")]
    [Description(@"??")]
    Proposed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Closed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bcugBNp-Ed-ak6NoX_4Aeg_-310506100")]
    [Description(@"??")]
    Closed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyMatched".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bcugBdp-Ed-ak6NoX_4Aeg_-310506070")]
    [Description(@"??")]
    PartiallyMatched,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Established".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bcugBtp-Ed-ak6NoX_4Aeg_-310506039")]
    [Description(@"??")]
    Established,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Active".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bcugB9p-Ed-ak6NoX_4Aeg_-310506038")]
    [Description(@"??")]
    Active,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Complete".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bcugCNp-Ed-ak6NoX_4Aeg_-310506009")]
    [Description(@"??")]
    Complete,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AmendmentRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bcugCdp-Ed-ak6NoX_4Aeg_-310505730")]
    [Description(@"??")]
    AmendmentRequested,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReActivateRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bc3p8Np-Ed-ak6NoX_4Aeg_-310505729")]
    [Description(@"??")]
    ReActivateRequested,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CloseRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bc3p8dp-Ed-ak6NoX_4Aeg_-310505699")]
    [Description(@"??")]
    CloseRequested,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompleteRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bc3p8tp-Ed-ak6NoX_4Aeg_-310505698")]
    [Description(@"??")]
    CompleteRequested,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StatusExtensionRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bc3p89p-Ed-ak6NoX_4Aeg_-255095303")]
    [Description(@"??")]
    StatusExtensionRequested,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DataSetAcceptanceRequested".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bc3p9Np-Ed-ak6NoX_4Aeg_-231081862")]
    [Description(@"??")]
    DataSetAcceptanceRequested,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BaselineStatus3CodeMetadataExtensions
{
    private static readonly BaselineStatus3CodeDropdownSource _dropdownSource = new BaselineStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBaselineStatus3CodeDropdownRow GetMetadata(this BaselineStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

