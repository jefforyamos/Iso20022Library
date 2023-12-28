﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PledgeeType1Code.  ISO2002 ID# _Ryn6UFj2EeSYweXGddZAOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of pledgee.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ryn6UFj2EeSYweXGddZAOA")]
[Description(@"Specifies the type of pledgee.")]
[DerivedFrom(typeof(PledgeeTypeCode))]
public enum PledgeeType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Counterparty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o56mAVj2EeSYweXGddZAOA")]
    [Description(@"??")]
    Counterparty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegulatoryBody".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pCsHgVj2EeSYweXGddZAOA")]
    [Description(@"??")]
    RegulatoryBody,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PledgeeType1CodeMetadataExtensions
{
    private static readonly PledgeeType1CodeDropdownSource _dropdownSource = new PledgeeType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPledgeeType1CodeDropdownRow GetMetadata(this PledgeeType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

