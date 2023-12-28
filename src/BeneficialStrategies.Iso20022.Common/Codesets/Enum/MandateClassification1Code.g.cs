﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MandateClassification1Code.  ISO2002 ID# _dYdaoGVREeacpJ-gG9kyUQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of direct debit amount, such as fixed or variable.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dYdaoGVREeacpJ-gG9kyUQ")]
[Description(@"Specifies the type of direct debit amount, such as fixed or variable.")]
[DerivedFrom(typeof(MandateClassificationCode))]
public enum MandateClassification1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fixed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nHOmAWVREeacpJ-gG9kyUQ")]
    [Description(@"??")]
    Fixed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UsageBased".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nMlnIWVREeacpJ-gG9kyUQ")]
    [Description(@"??")]
    UsageBased,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Variable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nVz0kWVREeacpJ-gG9kyUQ")]
    [Description(@"??")]
    Variable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MandateClassification1CodeMetadataExtensions
{
    private static readonly MandateClassification1CodeDropdownSource _dropdownSource = new MandateClassification1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMandateClassification1CodeDropdownRow GetMetadata(this MandateClassification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


