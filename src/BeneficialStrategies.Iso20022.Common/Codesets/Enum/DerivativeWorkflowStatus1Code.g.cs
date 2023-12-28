﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DerivativeWorkflowStatus1Code.  ISO2002 ID# _12PQkjL3EeKU9IrkkToqcw_-742843847.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of exchange's notice of change on a derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12PQkjL3EeKU9IrkkToqcw_-742843847")]
[Description(@"Specifies the status of exchange's notice of change on a derivative.")]
[DerivedFrom(typeof(DerivativeWorkflowStatusCode))]
public enum DerivativeWorkflowStatus1Code
{
    /// <summary>
    /// Notice is an advance warning that an adjustment may be applied.
    /// Encoded/decoded by serializers as "Preliminary".
    /// </summary>
    [EnumMember(Value = "PREL")]
    [IsoId("_12PQkzL3EeKU9IrkkToqcw_-1279574546")]
    [Description(@"Notice is an advance warning that an adjustment may be applied.")]
    Preliminary,
    
    /// <summary>
    /// Notice confirms that an adjustment will be applied.
    /// Encoded/decoded by serializers as "Adjustment".
    /// </summary>
    [EnumMember(Value = "ADJU")]
    [IsoId("_12PQlDL3EeKU9IrkkToqcw_1932288914")]
    [Description(@"Notice confirms that an adjustment will be applied.")]
    Adjustment,
    
    /// <summary>
    /// Notice confirms that no adjustment will be applied.
    /// Encoded/decoded by serializers as "NoAction".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_12PQlTL3EeKU9IrkkToqcw_-1908591113")]
    [Description(@"Notice confirms that no adjustment will be applied.")]
    NoAction,
    
    /// <summary>
    /// GCA VS (Global Corporate Actions Validation Service) is unable to confirm that there is a corporate action corresponding to this notice.
    /// Encoded/decoded by serializers as "Unconfirmed".
    /// </summary>
    [EnumMember(Value = "UCON")]
    [IsoId("_12ZBkDL3EeKU9IrkkToqcw_-77667944")]
    [Description(@"GCA VS (Global Corporate Actions Validation Service) is unable to confirm that there is a corporate action corresponding to this notice.")]
    Unconfirmed,
    
    /// <summary>
    /// Details were entered in error. All data should be ignored.
    /// Encoded/decoded by serializers as "Deleted".
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_12ZBkTL3EeKU9IrkkToqcw_247449563")]
    [Description(@"Details were entered in error. All data should be ignored.")]
    Deleted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DerivativeWorkflowStatus1CodeMetadataExtensions
{
    private static readonly DerivativeWorkflowStatus1CodeDropdownSource _dropdownSource = new DerivativeWorkflowStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDerivativeWorkflowStatus1CodeDropdownRow GetMetadata(this DerivativeWorkflowStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


