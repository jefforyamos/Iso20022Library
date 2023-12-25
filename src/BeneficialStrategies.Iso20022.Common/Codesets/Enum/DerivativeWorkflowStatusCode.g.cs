﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DerivativeWorkflowStatusCode.  ISO2002 ID# _12FfkzL3EeKU9IrkkToqcw_-117083409.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of exchange's notice of change on a derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12FfkzL3EeKU9IrkkToqcw_-117083409")]
[Description(@"Specifies the status of exchange's notice of change on a derivative.")]
public enum DerivativeWorkflowStatusCode
{
    /// <summary>
    /// Notice is an advance warning that an adjustment may be applied.
    /// </summary>
    [EnumMember(Value = "PREL")]
    [IsoId("_12FflDL3EeKU9IrkkToqcw_1152575769")]
    [Description(@"Notice is an advance warning that an adjustment may be applied.")]
    PREL,
    
    /// <summary>
    /// Notice confirms that an adjustment will be applied.
    /// </summary>
    [EnumMember(Value = "ADJU")]
    [IsoId("_12FflTL3EeKU9IrkkToqcw_1026052659")]
    [Description(@"Notice confirms that an adjustment will be applied.")]
    ADJU,
    
    /// <summary>
    /// Notice confirms that no adjustment will be applied.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_12FfljL3EeKU9IrkkToqcw_757086237")]
    [Description(@"Notice confirms that no adjustment will be applied.")]
    NOAC,
    
    /// <summary>
    /// GCA VS (Global Corporate Actions Validation Service) is unable to confirm that there is a corporate action corresponding to this notice.
    /// </summary>
    [EnumMember(Value = "UCON")]
    [IsoId("_12PQkDL3EeKU9IrkkToqcw_1014152022")]
    [Description(@"GCA VS (Global Corporate Actions Validation Service) is unable to confirm that there is a corporate action corresponding to this notice.")]
    UCON,
    
    /// <summary>
    /// Details were entered in error. All data should be ignored.
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_12PQkTL3EeKU9IrkkToqcw_954160850")]
    [Description(@"Details were entered in error. All data should be ignored.")]
    DLTD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DerivativeWorkflowStatusCodeMetadataExtensions
{
    private static readonly DerivativeWorkflowStatusCodeDropdownSource _dropdownSource = new DerivativeWorkflowStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDerivativeWorkflowStatusCodeDropdownRow GetMetadata(this DerivativeWorkflowStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


