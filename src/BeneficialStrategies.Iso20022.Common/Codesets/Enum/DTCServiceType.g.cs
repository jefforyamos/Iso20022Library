﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCServiceType.  ISO2002 ID# _14xnMDL3EeKU9IrkkToqcw_393105217.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of DTC (The Depository Trust Company) service, for example Cash In Lieu/ Round Up, Foreign Tax Relief, etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_14xnMDL3EeKU9IrkkToqcw_393105217")]
[Description(@"Indicates the type of DTC (The Depository Trust Company) service, for example Cash In Lieu/ Round Up, Foreign Tax Relief, etc.")]
[Derivations(typeof(DTCServiceType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum DTCServiceType
{
    /// <summary>
    /// Cash In Lieu or Round Up service.
    /// Encoded/decoded by serializers as "CILR".
    /// </summary>
    [EnumMember(Value = "CILR")]
    [IsoId("_14xnMTL3EeKU9IrkkToqcw_1528822829")]
    [Description(@"Cash In Lieu or Round Up service.")]
    CashInLieuRoundUp,
    
    /// <summary>
    /// U.S. Tax Withholding service.
    /// Encoded/decoded by serializers as "USTX".
    /// </summary>
    [EnumMember(Value = "USTX")]
    [IsoId("_14xnMjL3EeKU9IrkkToqcw_744518473")]
    [Description(@"U.S. Tax Withholding service.")]
    USTaxWithholding,
    
    /// <summary>
    /// Foreign Tax Relief service.
    /// Encoded/decoded by serializers as "FTXR".
    /// </summary>
    [EnumMember(Value = "FTXR")]
    [IsoId("_14xnMzL3EeKU9IrkkToqcw_4781110")]
    [Description(@"Foreign Tax Relief service.")]
    ForeignTaxRelief,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCServiceTypeMetadataExtensions
{
    private static readonly DTCServiceTypeDropdownSource _dropdownSource = new DTCServiceTypeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCServiceTypeDropdownRow GetMetadata(this DTCServiceType code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


