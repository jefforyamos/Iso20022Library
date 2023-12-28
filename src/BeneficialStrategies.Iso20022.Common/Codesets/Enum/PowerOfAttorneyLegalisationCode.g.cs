﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PowerOfAttorneyLegalisationCode.  ISO2002 ID# _aHytYdp-Ed-ak6NoX_4Aeg_-1168571799.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the legal constraint on the power of attorney.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHytYdp-Ed-ak6NoX_4Aeg_-1168571799")]
[Description(@"Indicates the legal constraint on the power of attorney.")]
[Derivations(typeof(PowerOfAttorneyLegalisation1Code))]
// External derivations that should be provided by the proper interface are: 
public enum PowerOfAttorneyLegalisationCode
{
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a notary.
    /// Encoded/decoded by serializers as "NOTA".
    /// </summary>
    [EnumMember(Value = "NOTA")]
    [IsoId("_aHytYtp-Ed-ak6NoX_4Aeg_-1070679660")]
    [Description(@"Indicates that the power of attorney must be legalised by a notary.")]
    Notary,
    
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a local authority.
    /// Encoded/decoded by serializers as "LOCA".
    /// </summary>
    [EnumMember(Value = "LOCA")]
    [IsoId("_aHytY9p-Ed-ak6NoX_4Aeg_-999567985")]
    [Description(@"Indicates that the power of attorney must be legalised by a local authority.")]
    LocalAuthority,
    
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a legal officer.
    /// Encoded/decoded by serializers as "APOS".
    /// </summary>
    [EnumMember(Value = "APOS")]
    [IsoId("_aHytZNp-Ed-ak6NoX_4Aeg_-685567932")]
    [Description(@"Indicates that the power of attorney must be legalised by a legal officer.")]
    Apostilled,
    
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a consular officer.
    /// Encoded/decoded by serializers as "COUN".
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_aHytZdp-Ed-ak6NoX_4Aeg_-621848373")]
    [Description(@"Indicates that the power of attorney must be legalised by a consular officer.")]
    Consularized,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PowerOfAttorneyLegalisationCodeMetadataExtensions
{
    private static readonly PowerOfAttorneyLegalisationCodeDropdownSource _dropdownSource = new PowerOfAttorneyLegalisationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPowerOfAttorneyLegalisationCodeDropdownRow GetMetadata(this PowerOfAttorneyLegalisationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


