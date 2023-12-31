﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionInformationTypeCode.  ISO2002 ID# _AqQfMCXcEeOFIcNWlDEvdQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of information event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AqQfMCXcEeOFIcNWlDEvdQ")]
[Description(@"Specifies the type of information event.")]
[Derivations(typeof(CorporateActionInformationType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CorporateActionInformationTypeCode
{
    /// <summary>
    /// Information is about an informal call when an issuer, trustee, agent wishes to talk to note holders to discuss a certain issue or potential change to the notes; nothing said being binding.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_axnpoCXcEeOFIcNWlDEvdQ")]
    [Description(@"Information is about an informal call when an issuer, trustee, agent wishes to talk to note holders to discuss a certain issue or potential change to the notes; nothing said being binding.")]
    ConferenceCall,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionInformationTypeCodeMetadataExtensions
{
    private static readonly CorporateActionInformationTypeCodeDropdownSource _dropdownSource = new CorporateActionInformationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionInformationTypeCodeDropdownRow GetMetadata(this CorporateActionInformationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


