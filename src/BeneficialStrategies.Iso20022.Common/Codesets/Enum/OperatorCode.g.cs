﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OperatorCode.  ISO2002 ID# _aPPZMNp-Ed-ak6NoX_4Aeg_336257296.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code containing the operator used to indicate the relationship between a variable and a fixed value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPPZMNp-Ed-ak6NoX_4Aeg_336257296")]
[Description(@"Code containing the operator used to indicate the relationship between a variable and a fixed value.")]
[Derivations(typeof(Operator1Code))]
// External derivations that should be provided by the proper interface are: 
public enum OperatorCode
{
    /// <summary>
    /// Smaller than.
    /// Encoded/decoded by serializers as "SMAL".
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_aPPZMdp-Ed-ak6NoX_4Aeg_336257297")]
    [Description(@"Smaller than.")]
    SmallerThan,
    
    /// <summary>
    /// Smaller or equal to.
    /// Encoded/decoded by serializers as "SMEQ".
    /// </summary>
    [EnumMember(Value = "SMEQ")]
    [IsoId("_aPPZMtp-Ed-ak6NoX_4Aeg_336257298")]
    [Description(@"Smaller or equal to.")]
    SmallerOrEqualTo,
    
    /// <summary>
    /// Greater than.
    /// Encoded/decoded by serializers as "GREA".
    /// </summary>
    [EnumMember(Value = "GREA")]
    [IsoId("_aPPZM9p-Ed-ak6NoX_4Aeg_336257299")]
    [Description(@"Greater than.")]
    GreaterThan,
    
    /// <summary>
    /// Greater or equal to.
    /// Encoded/decoded by serializers as "GREQ".
    /// </summary>
    [EnumMember(Value = "GREQ")]
    [IsoId("_aPPZNNp-Ed-ak6NoX_4Aeg_336257300")]
    [Description(@"Greater or equal to.")]
    GreaterOrEqualTo,
    
    /// <summary>
    /// Equal to.
    /// Encoded/decoded by serializers as "EQAL".
    /// </summary>
    [EnumMember(Value = "EQAL")]
    [IsoId("_aPPZNdp-Ed-ak6NoX_4Aeg_336257301")]
    [Description(@"Equal to.")]
    EqualTo,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OperatorCodeMetadataExtensions
{
    private static readonly OperatorCodeDropdownSource _dropdownSource = new OperatorCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOperatorCodeDropdownRow GetMetadata(this OperatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


